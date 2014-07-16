using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car

{
   
       

    class Program
    {
        public partial class Form1:Form
        {
            int startingMileage;
            int endingMileage;
            double milesTraveled;
            double reimburseRate = .39;
            double amountOwed;

            public Form1()
            {
                private void button1_Click(object sender, EventArgs e)
                {
                startingMileage =(int)numericUpDown1.Value;
                endingMileage=(int)numericUpDown2.Value;

                    if (startingMileage< endingMileage)
                    {
                        milesTraveled=endingMileage-=startingMileage;
                        amountOwed= milesTraveled*=reimburseRate;
                        label4.Text="$" + amountOwed;
	{
		 
	}

                    }
                    else
                    {
                    MessageBox.Show("Ha ha");
                    }


        
                }
            }

            


        }
    }
}
