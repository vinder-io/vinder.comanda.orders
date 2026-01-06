/* global using for System namespaces here */

global using System.Net;
global using System.Net.Http.Json;

global using System.Text;
global using System.Text.Json;

global using System.Security.Claims;
global using System.Text.Encodings.Web;

/* global using for Microsoft namespaces here */

global using Microsoft.AspNetCore.Authentication;
global using Microsoft.AspNetCore.Authorization;

global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.Extensions.DependencyInjection;

/* global using for Vinder namespaces here */

global using Vinder.Comanda.Orders.WebApi;

global using Vinder.Comanda.Orders.Domain.Repositories;
global using Vinder.Comanda.Orders.Domain.Entities;
global using Vinder.Comanda.Orders.Domain.Errors;
global using Vinder.Comanda.Orders.Domain.Concepts;
global using Vinder.Comanda.Orders.Domain.Filtering;

global using Vinder.Comanda.Orders.Application.Payloads;
global using Vinder.Comanda.Orders.Application.Payloads.Order;

global using Vinder.Comanda.Orders.TestSuite.Fixtures;

global using Vinder.Internal.Essentials.Patterns;
global using Vinder.Internal.Essentials.Primitives;
global using Vinder.Internal.Essentials.Utilities;

/* global usings for third-party namespaces here */

global using MongoDB.Driver;
global using DotNet.Testcontainers.Builders;
global using DotNet.Testcontainers.Containers;
global using AutoFixture;
