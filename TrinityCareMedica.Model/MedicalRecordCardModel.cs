using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCareMedica.Model
{
    public class MedicalRecordCardModel
    {
        public int RecordID { get; set; }
        public DateTime RecordDate { get; set; }
        public string RoomName { get; set; }
        public string Diagnosis { get; set; }
        public string Notes { get; set; }
        public string Medications { get; set; }
        public string Treatments { get; set; }
    }
}
