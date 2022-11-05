namespace APIRest_G9.Models.ComprobanteContainer
{
    public class Ticket
    {
        public int NroTicket { get; set; }
        public FuncionContainer.Funcion Funcion { get; set; }
        public SalaContainer.Butaca Butaca { get; set; }
        public Comprobante Comprobante { get; set; }
        public Promo Promo { get; set; }
    }
}
