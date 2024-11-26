using Microsoft.AspNetCore.Mvc;
using WebApp.Model.Movies;

namespace WebApp.Controllers;
[ApiController]
[Route("/api/companies")]
public class CompanyApiController : ControllerBase
{
    private MoviesDbContext _context;
}