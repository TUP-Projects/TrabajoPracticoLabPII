using Academika.Client;
using AcademikaBackend.BusinessLayer.Entities;
using AcademikaBackend.BusinessLayer.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academika.Presentacion
{
    public partial class FrmEdit : Form
    {
        private Forms forms1;
        private ICursosService _serviceCurso;
        private IMateriasService _serviceMateria;
        private ICarrerasService _serviceCarrera;
        private int _Id;

        public FrmEdit()
        {
            InitializeComponent();
            _serviceCurso = new ServiceFactoryImp().CrearServiceCursos();
            _serviceMateria = new ServiceFactoryImp().CrearServiceMaterias();
            _serviceCarrera = new ServiceFactoryImp().CrearServiceCarreras();
        }

        public void CargarDatos(Forms forms, int id)
        {
            switch (forms)
            {
                case Forms.Carrera:
                    Carrera carrera = _serviceCarrera.ConsultarCarreraById(id);
                    Nup_Duracion.Value = Convert.ToInt32(carrera.Duracion);
                    OcultarDuracion(true);
                    SetearDatos(carrera.NombreCarrera, forms, id);
                    break;
                case Forms.Curso:
                    Curso curso = _serviceCurso.ConsultarCursoById(id);
                    OcultarDuracion(false);
                    SetearDatos(curso.NombreCurso, forms, id);
                    break;
                case Forms.Materia:
                    Materia materia = _serviceMateria.ConsultarMateriaById(id);
                    OcultarDuracion(false);
                    SetearDatos(materia.NombreMateria, forms, id);
                    break;
            }
        }

        private void SetearDatos(string nombre, Forms forms, int id)
        {
            txtNombre.Text = nombre;
            forms1 = forms;
            _Id = id;
        }

        private void OcultarDuracion(bool ocultar)
        {
            lblDuracion.Visible = ocultar;
            Nup_Duracion.Visible = ocultar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (forms1)
            {
                case Forms.Carrera:
                    if (!ValidarCampoCarrera())
                        return;
                    Carrera carrera = new Carrera();
                    carrera.Id_Carrera = _Id;
                    carrera.NombreCarrera = txtNombre.Text;
                    carrera.Duracion = Convert.ToString(Nup_Duracion.Value);
                    if (_serviceCarrera.ActualizarCarrera(carrera))
                    {
                        MessageBox.Show("Carrera modificada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, la carrera no se pudo modificar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case Forms.Curso:
                    if (!ValidarCampoCurso())
                        return;
                    Curso curso = new Curso();
                    curso.Id_Curso = _Id;
                    curso.NombreCurso = txtNombre.Text;
                    if (_serviceCurso.ActualizarCurso(curso))
                    {
                        MessageBox.Show("Curso modificado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, el curso no se pudo modificar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    break;
                case Forms.Materia:
                    if (!ValidarCampoMateria())
                        return;
                    Materia materia = new Materia();
                    materia.NombreMateria = txtNombre.Text;
                    materia.Id_Materia = _Id;
                    if (_serviceMateria.ActualizarMateria(materia))
                    {
                        MessageBox.Show("Materia modificada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, la materia no se pudo modificar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    break;
            }
        }

        private bool ValidarCampoMateria()
        {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Se debe ingresar un nombre de la materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private bool ValidarCampoCarrera()
        {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Se debe ingresar un nombre de la carrera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(Nup_Duracion.Value.ToString().Trim()))
            {
                MessageBox.Show("Se debe ingresar una duracion de la carrera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private bool ValidarCampoCurso()
        {
            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Se debe ingresar un nombre del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar) || Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
