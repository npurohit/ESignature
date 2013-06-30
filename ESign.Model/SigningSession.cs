using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ESign.Model
{
    public class SigningSession
    {

        public string Name { get; set; }
        public string LineOfBusiness { get; set; }
        public List<Document> Documents { get; set; }
 
        public SignatureStatus Status
        {
            get
            {
                if (Documents.All(d => d.Status == SignatureStatus.Complete))
                {
                    return SignatureStatus.Complete;
                }

                return Documents.Any(d => d.Status == SignatureStatus.Incomplete)
                           ? SignatureStatus.Incomplete
                           : SignatureStatus.InProgress;
            }
        }

        public Image StatusIcon
        {
            get { return Helpers.GetStatusImage(Status); }
        }
    }
}
