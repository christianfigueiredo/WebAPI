using Microsoft.EntityFrameworkCore.Metadata;
using WebAPI.Models;

namespace WebAPI.Services.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios() ;

        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);

        Task<ServiceResponse<FuncionarioModel>> GetFuncionariosById(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionarios(FuncionarioModel editadoFuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionarios(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionario(int id);
    }
}
