//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prototype.Infra.Data {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SeedDataBase {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SeedDataBase() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Prototype.Infra.Data.SeedDataBase", typeof(SeedDataBase).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a --INSERT CONTACTS
        ///
        ///INSERT INTO Contacts (CreatedDate, Active, FullName, PhoneNumber)
        ///VALUES(&apos;2022-12-30&apos;, 1, &apos;Matheus Gael Freitas&apos;, &apos;(64) 2634-2953&apos;);
        ///
        ///INSERT INTO Contacts (CreatedDate, Active, FullName, PhoneNumber)
        ///VALUES(&apos;2022-12-30&apos;, 1, &apos;Leandro Benício Carvalho&apos;, &apos;(64) 98364-5983&apos;);
        ///
        ///INSERT INTO Contacts (CreatedDate, Active, FullName, PhoneNumber)
        ///VALUES(&apos;2022-12-30&apos;, 1, &apos;Geraldo Augusto da Cunha&apos;, &apos;(64) 3753-5362&apos;);
        ///
        ///INSERT INTO Contacts (CreatedDate, Active, FullName, PhoneNumber)
        ///VALU [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string InsertContatcs {
            get {
                return ResourceManager.GetString("InsertContatcs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a --INSERT INVITATIONS
        ///
        ///INSERT INTO Invitations(CreatedDate, Active, ContactId, [Number], Street , Complement, Neighborhood, City, State, PostalCode, Email, Category, Price, Description, Status)
        ///VALUES(&apos;2022-12-30&apos;, 1, 1, &apos;10&apos;,&apos;Avenida Belchior de Godoy&apos;, &apos;Setor Central&apos;, &apos;Setor Central&apos;, &apos;Anhangüera&apos;, &apos;GO&apos;, &apos;75779-970&apos;, &apos;matheus_gael_freitas@sistectecnologia.com.br&apos;, 1, 68.52, &apos;&apos;, null);
        ///
        ///INSERT INTO Invitations(CreatedDate, Active, ContactId, [Number], Street , Complement, Neighborhood, City, State, Po [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string InsertInvitations {
            get {
                return ResourceManager.GetString("InsertInvitations", resourceCulture);
            }
        }
    }
}
