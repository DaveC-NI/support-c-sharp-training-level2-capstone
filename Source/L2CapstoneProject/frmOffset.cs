using System;
using System.Windows.Forms;

namespace L2CapstoneProject
{
    public partial class frmOffset : Form
    {
        public PhaseAmplitudeOffset newPhaseAmp;

        public enum Mode { Add, Edit }

        public Mode ViewMode { get; }

        public frmOffset(Mode mode)
        {
            InitializeComponent();
            ViewMode = mode;

            switch (ViewMode)
            {
                case Mode.Add:
                    this.Text = "Add New Offset";
                    break;
                case Mode.Edit:
                    this.Text = "Edit Offset";
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double newPhase = Convert.ToDouble(numPhase.Value);
            double newAmp = Convert.ToDouble(numAmp.Value);
            newPhaseAmp = new PhaseAmplitudeOffset(newPhase, newAmp);

            Close();
        }

        private void frmOffset_Load(object sender, EventArgs e)
        {

        }
    }
}
