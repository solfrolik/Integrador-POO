using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_integrador_Poo
{
   public partial class Form1 : Form
   {
      private List<Persona> personas = new List<Persona>();
      public Form1()
      {
         InitializeComponent();
         dTPFechaAlta.Format = DateTimePickerFormat.Short;
         dTPFechaAlta.Value = DateTime.Now;
         txtAntiguedad.ReadOnly = true;
      }
      void CargarDatos()
      {
         lstPersonas.Items.Clear();
         foreach (var item  in personas)
         {
            lstPersonas.Items.Add(item.ToString());
         }
      }

      private void btnAlta_Click(object sender, EventArgs e)
      {
         try 
         { 
         Persona p = new Persona(txtNombre.Text, txtApellido.Text, txtDNI.Text, dTPFechaAlta.Value);

         string antiguedad = p.CalcularAntiguedad();
         
         txtAntiguedad.Clear();
         txtAntiguedad.Text = antiguedad.ToString();

         personas.Add(p);
         CargarDatos();

         txtNombre.Clear();
         txtApellido.Clear();
         txtDNI.Clear();
         dTPFechaAlta.Value = DateTime.Now;
         
         }

         catch (Exception ex)
         {
         MessageBox.Show($"Error al agregar a una persona: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
      private void btnBuscar_Click(object sender, EventArgs e)
      {
         string dni = txtDNI.Text;
         Persona PersonaEncontrada = personas.FirstOrDefault(p => p.DNI == dni);

         if (PersonaEncontrada != null)
         {
            MessageBox.Show($"Nombre: {PersonaEncontrada.Nombre} \nApellido: {PersonaEncontrada.Apellido}\nDNI: {PersonaEncontrada.DNI}", "Persona Encontrada");
         }
         else
         {
            MessageBox.Show("Persona no encontrada");
         }

      }
   }
}
