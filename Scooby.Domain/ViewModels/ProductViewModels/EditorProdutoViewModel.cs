using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Scooby.Domain.ViewModels.ProductViewModels
{
    public class EditorProdutoViewModel : Notifiable, IValidatable
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long CategoryId { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .HasMaxLen(Nome, 120, "Nome", "O Nome deve conter no Maximo 120 Caracteres.")
                .HasMinLen(Nome, 5, "Nome", "O Nome deve conter no Minimo 5 Caracteres")
            );
        }
    }
}
