using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftWare_Engineering
{
    class Function
    {
       
            static  public int counter = 0;
    static  public void Undo()
        {

            Levels L = new Levels();
            L.Show();
         
        }

        static public void HowDigree(int counter)
        {

            if (counter<=3)
            {
                MessageBox.show("Very Exellent");
            }
            else if (counter >3||counter <=9)
            {
                MessageBox.show("Very Good");
            }
            else if (counter >9||counter <=12)
            {
                MessageBox.show("Good");
            }
            else
            {
                MessageBox.show("you should study more");
            }
        }
}
}
