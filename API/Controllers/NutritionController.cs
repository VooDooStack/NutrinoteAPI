using System.Security.Claims;
using Application.NutritionLog;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class NutritionController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<NutritionLog>>> GetNutrition(CancellationToken cancellationToken)
    {
        return await Mediator.Send(new List.Query
            {
                AppUserId = HttpContext.User.FindFirstValue(FirebaseUserClaimType.ID)
            },
            cancellationToken);
    }

    [HttpPost("log")]
    public async Task<ActionResult<Unit>> LogNutrition(NutritionLog nutrition, CancellationToken cancellationToken)
    {
        nutrition.AppUserId = HttpContext.User.FindFirstValue(FirebaseUserClaimType.ID);
        return await Mediator.Send(new Create.Command { Nutrition = nutrition }, cancellationToken);
    }
}