using Coderland_BackEnd_Challenge.Controllers;
using Coderland_BackEnd_Challenge.Models;
using Coderland_BackEnd_Challenge.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class MarcasAutosControllerTests
{
    private readonly Mock<ICarBrandService> _carBrandServiceMock;
    private readonly Mock<ILogger<MarcasAutosController>> _loggerMock;
    private readonly MarcasAutosController _controller;

    public MarcasAutosControllerTests()
    {
        _carBrandServiceMock = new Mock<ICarBrandService>();
        _loggerMock = new Mock<ILogger<MarcasAutosController>>();
        _controller = new MarcasAutosController(_carBrandServiceMock.Object, _loggerMock.Object);
    }

    [Fact]
    public async Task GetMarcas_ReturnsAllMarcas()
    {

        var marcas = new List<CarBrands>
        {
            new CarBrands { Id = 1, Name = "Toyota" },
            new CarBrands { Id = 2, Name = "Ford" },
            new CarBrands { Id = 3, Name = "Chevrolet" }
        };

        _carBrandServiceMock.Setup(service => service.GetAllMarcasAsync()).ReturnsAsync(marcas);

        var result = await _controller.GetMarcas();

        var okResult = Assert.IsType<OkObjectResult>(result);
        var resultMarcas = Assert.IsType<List<CarBrands>>(okResult.Value);
        Assert.Equal(3, resultMarcas.Count);
    }

    [Fact]
    public async Task CreateMarca_ValidMarca_ReturnsCreatedResult()
    {

        var newMarca = new CarBrands { Id = 4, Name = "Nissan" };
        _carBrandServiceMock.Setup(service => service.CreateMarcaAsync(newMarca)).ReturnsAsync(newMarca);

        var result = await _controller.CreateMarca(newMarca);

        var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
        var createdMarca = Assert.IsType<CarBrands>(createdAtActionResult.Value);
        Assert.Equal(newMarca.Id, createdMarca.Id);
    }

    [Fact]
    public async Task UpdateMarca_ExistingMarca_ReturnsNoContent()
    {
        var existingMarca = new CarBrands { Id = 1, Name = "Toyota" };
        _carBrandServiceMock.Setup(service => service.UpdateMarcaAsync(existingMarca)).ReturnsAsync(true);

        var result = await _controller.UpdateMarca(existingMarca.Id, existingMarca);

        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteMarca_ExistingMarca_ReturnsNoContent()
    {
        int idToDelete = 1;
        _carBrandServiceMock.Setup(service => service.DeleteMarcaAsync(idToDelete)).ReturnsAsync(true);

        var result = await _controller.DeleteMarca(idToDelete);
        Assert.IsType<NoContentResult>(result);
    }

}
