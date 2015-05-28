using QuadModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEntityFramework.Entities
{
    public class ActiveQuadEntity
    {
        public int ActiveQuadEntityId { get; set; }

        [Required]
        public string QuadId { get; set; }

        [Required]
        public CommsOptions SupportedComms { get; set; }

        [Required]
        public IMUOpions SupportedIMU { get; set; }

        [Required]
        public GPSOptions SupportGPS { get; set; }

        [Required]
        public AltimeterOptions SupportedAlt { get; set; }

        [Required]
        public bool InUse { get; set; }
    }
}
