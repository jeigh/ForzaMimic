using System;
using System.ComponentModel;
using System.Dynamic;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace ForzaMimic.TransferObjects
{
    // making this one big mega-class of state instead of more granular Transfer Objects because yagni
    public class FieldStudy : TunedCar
    {
        private string _videoUrl = String.Empty;

        public Guid FieldStudyId { get; set; }
                
        [DisplayName("Lap Count")]
        public int FieldLaps { get; set; }
        [DisplayName("Totals Seconds Elapsed")]
        public decimal ElapsedTotal { get; set; }   
        [DisplayName("Was Rolling Start?")]
        public bool RollingStart { get; set; }

        [DisplayName("Field Test Comments")]
        public string FieldTestComments { get; set; } = string.Empty;

        [DisplayName("Field Test Video")]
        public string VideoUrl
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_videoUrl))
                    return "https://www.youtube.com/embed/dQw4w9WgXcQ";  // please forgive me
                
                return _videoUrl;
            }
            set => _videoUrl = value;
        }

        public string CardColor { get; set; }
    }
}
