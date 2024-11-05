// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AvaliacaoA1.Areas.Identity.Pages.Account.Manage
{
    public class DownloadPersonalDataModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<DownloadPersonalDataModel> _logger;

        public DownloadPersonalDataModel(
            UserManager<IdentityUser> userManager,
            ILogger<DownloadPersonalDataModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Não foi possível carregar o usuário com ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("O usuário com ID '{UserId}' solicitou seus dados pessoais.", _userManager.GetUserId(User));

            // Inclua apenas dados pessoais para download
            var dadosPessoais = new Dictionary<string, string>();
            var propriedadesDadosPessoais = typeof(IdentityUser).GetProperties().Where(
                            prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));
            foreach (var p in propriedadesDadosPessoais)
            {
                dadosPessoais.Add(p.Name, p.GetValue(user)?.ToString() ?? "null");
            }

            var logins = await _userManager.GetLoginsAsync(user);
            foreach (var l in logins)
            {
                dadosPessoais.Add($"Chave do provedor de login externo {l.LoginProvider}", l.ProviderKey);
            }

            dadosPessoais.Add("Chave do Autenticador", await _userManager.GetAuthenticatorKeyAsync(user));

            Response.Headers.TryAdd("Content-Disposition", "attachment; filename=DadosPessoais.json");
            return new FileContentResult(JsonSerializer.SerializeToUtf8Bytes(dadosPessoais), "application/json");
        }
    }
}
