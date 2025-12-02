global using System.Diagnostics.CodeAnalysis;
global using System.Text.Json;
global using System.Web;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authorization;

global using Vinder.Comanda.Orders.WebApi.Extensions;
global using Vinder.Comanda.Orders.Domain.Errors;

global using Vinder.Comanda.Orders.Application.Payloads.Order;
global using Vinder.Comanda.Orders.Application.Payloads;

global using Vinder.Comanda.Orders.Infrastructure.IoC.Extensions;

global using Vinder.Comanda.Orders.CrossCutting.Configurations;
global using Vinder.Comanda.Orders.CrossCutting.Constants;

global using Vinder.Dispatcher.Contracts;
global using Vinder.IdentityProvider.Sdk.Extensions;

global using Scalar.AspNetCore;
global using FluentValidation.AspNetCore;