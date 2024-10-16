using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.interfaces;

public interface iAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}