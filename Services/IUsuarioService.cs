using OliCook.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace OliCook.Services;

    public interface IUsuarioService
    {
       Task<UsuarioVM> GetUsuarioLogado();
       Task<SignInResult> LoginUsuario(LoginVM login);
       Task LogoffUsuario();
       Task<List<string> RegistrarUsuario(RegistroVM registro);
       Task<bool> ConfirmarEmail(string userId, string code);

    }