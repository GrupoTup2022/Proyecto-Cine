namespace APIRest_G9.Models.ComprobanteContainer
{
    public class Comprobante
    {
        public int Id { get; set; }
        public List<FormaPago> FormaPagos { get; set; }
        public FormaVenta FormaVenta { get; set; }
        public DateTime Fecha { get;set; }
        public List<Ticket> ltickets { get; set; }


        public Comprobante()
        {
            FormaPagos = new List<FormaPago>();
            ltickets = new List<Ticket>();
            Fecha = DateTime.Now;
            Id = 0;
        }

        public void AgregarTicke(Ticket t)
        {
            ltickets.Add(t);
        }
        public void RemoverTicker(int pos)
        {
            ltickets.RemoveAt(pos);
        }

        public void AgregarF_Pago (FormaPago fp)
        {
            FormaPagos.Add(fp); 
        }

        public void RemoverFormaPago (int pos)
        {
            FormaPagos.RemoveAt(pos);
        }
       
    }
}
