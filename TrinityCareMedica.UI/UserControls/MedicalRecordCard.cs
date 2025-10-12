using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class MedicalRecordCard : UserControl
    {
        MedicalRecordController medicalRecordController;
        int CardRecordID;
        public MedicalRecordCard(int RecordID)
        {
            medicalRecordController = new MedicalRecordController();
            CardRecordID = RecordID;
            InitializeComponent();
        }
        private void LoadData()
        {
            List<MedicalRecordCardModel> cards = medicalRecordController.GetMedicalRecordCards(FormMain.selectedPatientID);
            for (int i = 0; i < cards.Count; i++)
            {
                    labelRecordID.Text = $"Record #{cards[i].RecordID.ToString()}";
                    labelRecordDate.Text = cards[i].RecordDate.ToString();
                    labelRoom.Text = $"Room: {cards[i].RoomName}";
                    labelDoctor.Text = $"Doctor: \n{cards[i].DoctorName}";
                    labelDiagnosis.Text = $"Diagnosis: {cards[i].Diagnosis}";
                    textboxNotes.Text = cards[i].Notes;
                    textboxMedications.Text = cards[i].Medications;
                    textboxTreatments.Text = cards[i].Treatments;
            }
        }

        private void MedicalRecordCard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
