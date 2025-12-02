global using System.Text.Json.Serialization;

global using Vinder.Comanda.Orders.Domain.Entities;
global using Vinder.Comanda.Orders.Domain.Errors;
global using Vinder.Comanda.Orders.Domain.Contracts;
global using Vinder.Comanda.Orders.Domain.Concepts;
global using Vinder.Comanda.Orders.Domain.Repositories;
global using Vinder.Comanda.Orders.Domain.Filtering;

global using Vinder.Comanda.Orders.Application.Payloads;
global using Vinder.Comanda.Orders.Application.Payloads.Order;
global using Vinder.Comanda.Orders.Application.Mappers;

global using Vinder.Internal.Essentials.Contracts;
global using Vinder.Internal.Essentials.Patterns;
global using Vinder.Internal.Essentials.Entities;
global using Vinder.Internal.Essentials.Filters;
global using Vinder.Internal.Essentials.Primitives;

global using Vinder.Dispatcher.Contracts;
global using FluentValidation;