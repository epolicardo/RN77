using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text;
using RN77.BD.Models;
using RN77.BD.Datos.Entities;

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
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(resultado);
                return new Respuesta
                {
                    EsExitoso = true,
                    Resultado = list
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message
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
                    };
                }

                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return new Respuesta
                {
                    EsExitoso = true,
                    Resultado = list
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message
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
        public async Task<Respuesta> GetTokenAsync(string urlBase,
                                                   string servicePrefix,
                                                   string controller,
                                                   PedirToken request)
        {
            try
            {
                var requestString = JsonConvert.SerializeObject(request);
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
                    };
                }

                var token = JsonConvert.DeserializeObject<PedirToken>(result);
                return new Respuesta
                {
                    EsExitoso = true,
                    Resultado = token
                };
            }
            catch (Exception ex)
            {
                return new Respuesta
                {
                    EsExitoso = false,
                    Mensaje = ex.Message
                };
            }
        }

        public async Task<Respuesta> RegisterUserAsync(string urlBase,
                                                       string servicePrefix,
                                                       string controller,
                                                       RegistrarNuevoUsuarioViewModel nuevoUsuarioPeticion)
        {
            try
            {
                var request = JsonConvert.SerializeObject(nuevoUsuarioPeticion);
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
                                                          RecuperarPasswordViewModel recuperarPasswordPeticion)
        {
            try
            {
                var request = JsonConvert.SerializeObject(recuperarPasswordPeticion);
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
                                                         CambiarPasswordViewModel cambiarPasswordPeticion,
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