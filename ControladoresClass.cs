using System;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalBack.Repositorio;
using AutoMapper;

namespace ProyectoFinalBack.Controllers;

public class SocioDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string CorreoElectronico { get; set; }
    public int Telefono { get; set; }
    public string Sexo { get; set; }
}
public class SocioController : Controller
{
    private readonly IRepository<Socio> _socioRepository;
    private readonly IMapper _mapper;

    public SocioController(IRepository<Socio> socioRepository, IMapper mapper)
    {
        _socioRepository = socioRepository;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var socios = await _socioRepository.GetAll();
        var sociosDto = _mapper.Map<List<SocioDto>>(socios);
        return View(sociosDto);
    }
}