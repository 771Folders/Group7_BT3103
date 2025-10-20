using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCareMedica.Model
{
    public class PatientRoomModel
    {
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public string BedNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
