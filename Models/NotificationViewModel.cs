namespace Deco.Models
{
    public class NotificationViewModel
    {
        public NotificationViewModel(string tipo, string mensagem)
        {
            Type = tipo;
            Mensagem = mensagem;
        }

        public string Type { get; set; }
        public string Mensagem { get; set; }
    }
}
