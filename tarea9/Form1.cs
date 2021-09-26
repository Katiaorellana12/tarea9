using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    private void Form1_Load(object sender, EventArgs e)
    {
      
        fruta product = new fruta();

     
        product.setProductId(1);
        product.setproductnombre("Coco");
        product.setcantidad("2");
        product._precio = "$800";

  
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
    

      
        fruta product = new fruta();
        product.setProductId(Convert.ToInt32(textId.Text));
        product.setproductnombre(textName.Text);
        product.setcantidad(textDes.Text);
        product._precio = textPrecio.Text;

       
        lstBookInfo.Items.Add(product.getBookInfo());

    }

  

    private void textDes_TextChanged(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

   
}   }