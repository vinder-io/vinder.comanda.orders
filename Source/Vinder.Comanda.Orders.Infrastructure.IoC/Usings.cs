global using System.Diagnostics.CodeAnalysis;

global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;

global using Vinder.Comanda.Orders.Domain.Repositories;
global using Vinder.Comanda.Orders.Domain.Contracts;
global using Vinder.Comanda.Orders.Domain.Services;

global using Vinder.Comanda.Orders.CrossCutting.Configurations;
global using Vinder.Comanda.Orders.CrossCutting.Exceptions;
global using Vinder.Comanda.Orders.Infrastructure.Repositories;

global using Vinder.Comanda.Orders.Application.Payloads.Order;

global using Vinder.Comanda.Orders.Application.Handlers.Order;
global using Vinder.Comanda.Orders.Application.Validators;

global using Vinder.Internal.Essentials.Contracts;
global using Vinder.Internal.Infrastructure.Persistence.Repositories;

global using Vinder.Dispatcher.Extensions;

global using MongoDB.Driver;
global using FluentValidation;
