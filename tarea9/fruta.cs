using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea9
{
    class fruta
   {
        
  
        private int _productId;
        private string _nombre;
        private string _peso;
        
 
        public string _precio { get; set; }

  
        public fruta() 
        { }





        public int getproductId()
        {
            return _productId;
        }


   

        public void setProductId(int productId)
        {
            _productId = productId;
        }

        // nombre del producto
        public string getProductnombre()
        {
            return _nombre;
        }

        public void setproductnombre(string nombre)
        {
            _nombre = nombre;
        }

        public string getproductcantidad()
        {
            return _peso;
        }

        public void setcantidad(string cantidad)
        {
           _peso = cantidad;
        }

     

        public string getBookInfo()
        {
            return "Nombre: " + _nombre + "\tCantidad:"  + _productId +
                "\tPeso: " + _peso + "\tPrecio: " +
                _precio;
        }

    }

}
