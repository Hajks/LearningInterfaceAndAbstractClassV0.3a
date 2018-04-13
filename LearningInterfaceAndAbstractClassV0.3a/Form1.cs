using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInterfaceAndAbstractClassV0._3a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StingPatrol biff = new StingPatrol();
            NectarCollector bertha = new NectarCollector();
            IStingPatrol defender = biff; //We can add new reference only to class which implement this type of interface 
            INectarCollector cutiePie = bertha; // Now, we have two references to our object, so even if we set up bertha to null, our garbage collector will leave our object NectarCollector alive because there is still cutiePie reference.
            bertha = null;
            INectarCollector gatherer = new NectarCollector(); // So currently our heap looks like: 2 objects NectarCollector and 1 object StingPatrol. Cool!
            

        }
    }
}
