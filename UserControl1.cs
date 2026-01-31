using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario1
{ 
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(txtN1.Text), n2 = double.Parse(txtN2.Text);
                double n3 = double.Parse(txtN3.Text), n4 = double.Parse(txtN4.Text);
                double promedio = (n1 + n2 + n3 + n4) / 4;

                lblResultado.Text = $"Promedio: {promedio:F2}";

                if (promedio <= 69)
                {

                    txtCompletivo.Enabled = true;
                    MessageBox.Show("Debe ingresar nota de Completivo.");

                    if (!string.IsNullOrEmpty(txtCompletivo.Text))
                    {
                        double nComp = double.Parse(txtCompletivo.Text);
                        double resComp = (promedio * 0.50) + (nComp * 0.50);

                        if (resComp <= 69)
                        {
                            txtExtraordinario.Enabled = true;
                            MessageBox.Show("Debe ingresar nota de Extraordinario.");


                            if (!string.IsNullOrEmpty(txtExtraordinario.Text))
                            {
                                double nExtra = double.Parse(txtExtraordinario.Text);
                                double resExtra = (promedio * 0.30) + (nExtra * 0.70);

                                lblResultado.Text = resExtra <= 69 ? "Estado: REPROBADO" : $"Aprobado (Extra): {resExtra:F2}";


                            }
                            else
                            {
                                lblResultado.Text = $"Aprobado (Comp): {resComp:F2}";
                            }
                        }
                    }
                    else
                    {
                        lblResultado.Text = "Estado: APROBADO";
                    }

                }
            }
            catch { MessageBox.Show("Asegúrese de llenar los campos con números."); }
        }
            }
    }
                        
                    
                
            
    
    
