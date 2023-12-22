using Microsoft.AspNetCore.Datasync;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Mobile;
using MvcMovie.ViewModels;

namespace MvcMovie.Controllers;

[Route("api/mobile/movie")]
public class MobileMovieController : TableController<MobileMovie>
{
    public MobileMovieController(MvcMovieContext context) : base()
    {
        Repository = new MovieRepository(context);
    }
}
