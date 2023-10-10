using Final.Model.BuildPCModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final {
    public partial class BuildPcCart : Form {
        public static List<Accessory> buildPcCartItems = new List<Accessory>();

        public BuildPcCart() {
            InitializeComponent();
        }
    }
}
