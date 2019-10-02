using System.Collections.Generic;

namespace RN77.BD.Datos.Entities
{
    public partial class Mails : EntityBase
    {
        public Mails()
        {
            InstitucionMails = new HashSet<InstitucionMails>();
            PersonaMails = new HashSet<PersonaMails>();
        }


        public int TmailId { get; set; }
        public string Mail { get; set; }

        public virtual Tmails Tmail { get; set; }
        public virtual ICollection<InstitucionMails> InstitucionMails { get; set; }
        public virtual ICollection<PersonaMails> PersonaMails { get; set; }
    }
}
