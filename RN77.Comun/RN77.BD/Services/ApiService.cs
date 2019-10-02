using Newtonsoft.Json;
using RN77.BD.Datos.Entities;
using RN77.Comun.Models.Usuario;
using RN77.Comun.Models.Usuario.Request;
using RN77.Comun.Models.Varios;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RN77.BD.Services
{
    public class ApiService
    {
        #region GET
        public async Task<Respuesta> GetListAsync<T>(string urlBase,
                                                     string servicePrefix,
                                                     string controller)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var resultado = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = resultado,
                        Resultado = null
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(resultado);
                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = resultado,
                        Resultado = null
                    };
                }
                return new Respuesta
                {
                    EsExitoso = true,
                    Mensaje = "",
                    Resultado = list
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                    Resultado = null
                };
            }
        }

        public async Task<Respuesta> GetListAsync<T>(string urlBase,
                                                     string servicePrefix,
                                                     string controller,
                                                     string tokenType,
                                                     string accessToken)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase),
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);

                var url = $"{servicePrefix}{controller}";
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = result,
                        Resultado = null
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return new Respuesta
                {
                    EsExitoso = true,
                    Mensaje = "",
                    Resultado = list
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                    Resultado = null
                };
            }
        }
        #endregion

        #region POST
        public async Task<Respuesta> PostAsync<T>(string urlBase,
                                                     string servicePrefix,
                                                     string controller,
                                                     T model,
                                                     string tokenType,
                                                     string accessToken)
        {
            try
            {
                var request = JsonConvert.SerializeObject(model);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = answer,
                        Resultado = null
                    };
                }

                var obj = JsonConvert.DeserializeObject<T>(answer);
                return new Respuesta
                {
                    EsExitoso = true,
                    Mensaje = "",
                    Resultado = obj
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                    Resultado = null
                };
            }
        }
        #endregion

        #region PUT
        public async Task<Respuesta> PutAsync<T>(string urlBase,
                                                 string servicePrefix,
                                                 string controller,
                                                 int id,
                                                 T model,
                                                 string tokenType,
                                                 string accessToken)
        {
            try
            {
                var request = JsonConvert.SerializeObject(model);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var url = $"{servicePrefix}{controller}/{id}";
                var response = await client.PutAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = answer,
                    };
                }

                var obj = JsonConvert.DeserializeObject<T>(answer);
                return new Respuesta
                {
                    EsExitoso = true,
                    Resultado = obj,
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }

        public async Task<Respuesta> PutAsync<T>(string urlBase,
                                                 string servicePrefix,
                                                 string controller,
                                                 T model,
                                                 string tokenType,
                                                 string accessToken)
        {
            try
            {
                var request = JsonConvert.SerializeObject(model);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var url = $"{servicePrefix}{controller}";
                var response = await client.PutAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = answer,
                    };
                }

                var obj = JsonConvert.DeserializeObject<T>(answer);
                return new Respuesta
                {
                    EsExitoso = true,
                    Resultado = obj,
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }
        #endregion

        #region DELETE
        public async Task<Respuesta> DeleteAsync(string urlBase,
                                                 string servicePrefix,
                                                 string controller,
                                                 int id,
                                                 string tokenType,
                                                 string accessToken)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var url = $"{servicePrefix}{controller}/{id}";
                var response = await client.DeleteAsync(url);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = answer,
                    };
                }

                return new Respuesta
                {
                    EsExitoso = true
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }
        #endregion

        #region USUARIO
        /// <summary>
        /// Obtiene Token
        /// </summary>
        /// <param name="urlBase">p.ej. url = Application.Current.Resources["UrlAPI"].ToString()</param>
        /// <param name="servicePrefix">p.ej. /apiActores</param>
        /// <param name="controller">p.ej. /Personas</param>
        /// <param name="peticion">Models PedirTokenRequest</param>
        /// <returns></returns>
        public async Task<Respuesta> GetTokenAsync(string urlBase,
                                                  string servicePrefix,
                                                  string controller,
                                                  PedirTokenRequest peticion)
        {
            try
            {
                var requestString = JsonConvert.SerializeObject(peticion);
                var content = new StringContent(requestString, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, content);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = result,
                        Resultado = null
                    };
                }

                var token = JsonConvert.DeserializeObject<PedirTokenRequest>(result);
                return new Respuesta
                {
                    EsExitoso = true,
                    Mensaje = "",
                    Resultado = token
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                    Resultado = null
                };
            }
        }

        public async Task<Respuesta> RegisterUserAsync(string urlBase,
                                                       string servicePrefix,
                                                       string controller,
                                                       UsuarioRequest peticion)
        {
            try
            {
                var request = JsonConvert.SerializeObject(peticion);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<Respuesta>(answer);
                return obj;
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }

        public async Task<Respuesta> RecoverPasswordAsync(string urlBase,
                                                          string servicePrefix,
                                                          string controller,
                                                          EmailRequest peticion)
        {
            try
            {
                var request = JsonConvert.SerializeObject(peticion);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<Respuesta>(answer);
                return obj;
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }

        public async Task<Respuesta> GetUserByEmailAsync(string urlBase,
                                                         string servicePrefix,
                                                         string controller,
                                                         string email,
                                                         string tokenType,
                                                         string accessToken)
        {
            try
            {
                var request = JsonConvert.SerializeObject(new RecuperarPasswordViewModel { Email = email });
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Respuesta
                    {
                        EsExitoso = false,
                        Mensaje = answer,
                    };
                }

                var user = JsonConvert.DeserializeObject<Usuarios>(answer);
                return new Respuesta
                {
                    EsExitoso = true,
                    Resultado = user,
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }

        public async Task<Respuesta> ChangePasswordAsync(string urlBase,
                                                         string servicePrefix,
                                                         string controller,
                                                         CambiarPasswordRequest cambiarPasswordPeticion,
                                                         string tokenType,
                                                         string accessToken)
        {
            try
            {
                var request = JsonConvert.SerializeObject(cambiarPasswordPeticion);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, accessToken);
                var url = $"{servicePrefix}{controller}";
                var response = await client.PostAsync(url, content);
                var answer = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<Respuesta>(answer);
                return obj;
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message,
                };
            }
        }
        #endregion
    }
}