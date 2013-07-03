using System.Collections.Generic;
using System.Drawing;

namespace ESign.Model
{
    public class Document
    {
        public Document()
        {
            Status = SignatureStatus.Incomplete;
        }

        public string Name { get; set; }

        public List<Signer> Signers { get; set; } 

        public string PdfName { get; set; }

        public SignatureStatus Status { get; set; }

        public Image StatusIcon
        {
            //get { return null; }
            get { return Helpers.GetStatusImage(Status); }
        }
        
    }
}
