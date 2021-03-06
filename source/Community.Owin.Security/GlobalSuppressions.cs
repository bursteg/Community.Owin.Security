// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Owin", Justification = "Following the convention.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Owin.OAuth2AuthenticationExtensions.#UseGitHubAuthentication(Owin.IAppBuilder,Community.Owin.Security.GitHubAuthenticationOptions)", Justification = "Should be the same handle option.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Owin.OAuth2AuthenticationExtensions.#UseStackExchangeAuthentication(Owin.IAppBuilder,Community.Owin.Security.StackExchangeAuthenticationOptions)", Justification = "Should be the same handle option.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Community.Owin.Security.OAuth2AuthenticationOptions.#ctor(System.String,System.String,System.String,System.String)", Scope = "member", Target = "Community.Owin.Security.GitHubAuthenticationOptions.#.ctor(System.String,System.String)", Justification = "Localization is not supported yet.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Community.Owin.Security.OAuth2AuthenticationOptions.#ctor(System.String,System.String,System.String,System.String)", Scope = "member", Target = "Community.Owin.Security.StackExchangeAuthenticationOptions.#.ctor(System.String,System.String,System.String,System.String)", Justification = "Localization is not supported yet.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "PITA.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2243:AttributeStringLiteralsShouldParseCorrectly", Justification = "Version contains pre-release data.")]