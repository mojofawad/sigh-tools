using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SighTools.Boundary.Controllers;

[ApiController]
[Route("sightools/[controller]")]
public class BoundaryController(ILogger<BoundaryController> logger) : ControllerBase
{
    private readonly ILogger<BoundaryController> _logger = logger;

    [HttpGet(Name = "GetToolsBoundary")]
    public IEnumerable<ToolsBoundaryViewModel> Get()
    {
        return
        [
            new ToolsBoundaryViewModel("BoundaryOne", 1, "The description of BoundaryOne", "Type: bool"),
            new ToolsBoundaryViewModel("BoundaryTwo", 2, "The description of BoundaryTwo", "Type: string"),
            new ToolsBoundaryViewModel("BoundaryThree", 3, "The description of BoundaryThree", "Type: int")
        ];
        
    }
}

public class ToolsBoundaryViewModel(string boundaryName, int boundaryValue, string boundaryDescription, string boundaryType)
{
    public string BoundaryName { get; set; } = boundaryName;
    public int BoundaryValue { get; set; } = boundaryValue;
    public string BoundaryDescription { get; set; } = boundaryDescription;
    public string BoundaryType { get; set; } = boundaryType;
}