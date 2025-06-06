namespace Deco.Models
{
    public class Utils
    {
        public static string MensagemSucesso() => "Registro realizado com sucesso";

        public static string MensagemErro() => "Ocorreu um erro na operação, caso o erro persista entre em contato com o suporte: transparencia@controladoria.ro.gov.br";

        public static string MensagemParaPreencherCampos() => "Por favor, preencha todos os campos e tente novamente.";

        public static string GeradorDeSenha() => Guid.NewGuid().ToString().Substring(0, 8);
    }
}
