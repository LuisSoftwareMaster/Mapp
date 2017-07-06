using System;using System.Collections.Generic;using System.Diagnostics;using System.IO;using System.Net.Http;using System.Net.Http.Formatting;using System.Net.Http.Headers;using System.Text;using System.Threading.Tasks;using System.Xml.Serialization;using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.Client{	public class PorpoiseWebApiClient : IDisposable, IPorpoiseWebApiClient	{        private static XmlSerializer errorSerializer = new XmlSerializer(typeof(Error));		private string baseAddress;
		//Production http://api.porpoise.com
		//Test http://porpoiseapi.click

		//Production API KEY api_key_uS4bcabwKM4ZQrQT8RHUQgtt

		//Test API KEY api_key_or8L7EFAuUDQy7xbOELvpQtt
		private const string apiAddress = " http://porpoiseapi.click";
        //private const string apiAddress = "http://api.porpoise.com";
        //Production api_key_uS4bcabwKM4ZQrQT8RHUQgtt
        private const string API_KEY = "api_key_uS4bcabwKM4ZQrQT8RHUQgtt";		public PorpoiseWebApiClient()		{			this.baseAddress = apiAddress;		}		private HttpClient Client(bool xml = false)		{			//HttpClientHandler handler = new HttpClientHandler();			var client = new HttpClient();
			var headers = this.buildDefaultHeaders();			client.BaseAddress = new Uri(baseAddress);			client.DefaultRequestHeaders.Accept.Clear();			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(xml ? "text/xml" : "application/json"));			//client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue("PorpoiseMobile")));			foreach (var header in headers)			{				client.DefaultRequestHeaders.Add(header.Item1, header.Item2);			}            return client;		}		public  async Task<RequestEmployeeResponseModel> PerformRequestEmployee(string Fullname, string CompanyName, string companyEmail)		{			var requestEmployeeUrl = "" + apiAddress + "/v1/request_as_employee";			var requestModel = new RequestEmployeeRequestModel			{				fullname = Fullname,				company_name = CompanyName,				work_email = companyEmail			};			try			{				var result = await PerformPost<RequestEmployeeRequestModel, RequestEmployeeResponseModel>(requestEmployeeUrl, requestModel, IRequestFormat.JSON, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(error);				});				if (result != null && result.Successful)				{                    return result;				}				if (!result.Successful && result.Message.Equals("user_not_found"))				{					throw new PorpoiseException(Resource.AccountDoesNotExistError);				}				if (!result.Successful && result.Message.Equals("invalid_login"))				{					throw new PorpoiseException(Resource.LoginError);				}				else				{					Debug.WriteLine("MESSAGE: " + result.Message);					throw new PorpoiseException(Resource.PorpoiseConnectionError);				}			}			catch (PorpoiseException pe)			{				return new RequestEmployeeResponseModel(false, pe.Message);			}			catch (Exception ex)			{				throw new PorpoiseException(Resource.PorpoiseConnectionError);			}		}

		public async Task<SignupResponseModel> Signup(string email, string company_name, string first_name, string last_name)
		{
            var requestEmployeeUrl = "" + apiAddress + "/v1/signup";

            var signupModel = new SignupRequestModel
            {
                email = email,

                company_name = company_name,

                first_name = first_name,                last_name = last_name
			};
			try
			{

				var result = await PerformPost<SignupRequestModel, SignupResponseModel>(requestEmployeeUrl, signupModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});

				if (result != null && result.Successful)
				{


					return result;
				}

                throw new Exception("Please connect to the internet");
			}

			catch (PorpoiseException pe)
			{
				return new SignupResponseModel(false, pe.Message);
			}
			catch (Exception ex)
			{
				throw new PorpoiseException(Resource.PorpoiseConnectionError);
			}
		}

        public async Task<ResponseModel<Object>> Confirmcode(string mobilecode){            var requestCodeURL = "" + apiAddress + "/v1/verify_signup";            var confirmationModel = new CodeConfirmationRequestModel
            {

                mobile_code = mobilecode            };

			try
			{

				var result = await PerformPost<CodeConfirmationRequestModel, ResponseModel<Object>>(requestCodeURL, confirmationModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});

				if (result != null)
				{
					return result;
				}

				throw new Exception("Please connect to the internet");
			}

			
			catch (Exception ex)
			{
				throw new PorpoiseException(Resource.PorpoiseConnectionError);
			}        }


		public async Task<string> GetCompanyName() {

			try
			{
				var employee = await this.GetEmployee();				if (employee != null && employee.Successful) {

					HourLog latestPost = employee.LatestPost;					if (latestPost != null) {

						return latestPost.CompanyName;										}								}
				return null;
			}			catch (Exception ex) {

				Debug.WriteLine(ex.Message);				return null;						}				}		/// <summary>		/// Get specified employee. The auth.Token that is passed in the http header defines 		/// which user is logged in and get's their information without passing an Id		/// </summary>		/// <param ></param>		/// <returns></returns>
        /// <seealso cref="Client(bool)" cref="buildTestHeaders()"/>		public async Task<EmployeeResponseModel> GetEmployee()		{			try			{				var url = apiAddress+ "/v1/get_profile_data/";				var result = await PerformGet<EmployeeResponseModel>(url, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(Resource.PorpoiseConnectionError);				});				return result;			}			catch (Exception ex)			{				Debug.WriteLine("GET EMPLOYEE API CLIENT ERROR: "+ex.Message);				AccountInfo.Logout();				return null;				//throw new PorpoiseException(ex.Message);			}		}		/// <summary>		/// Get all goals that belong to the specified Company.		/// </summary>		/// <param name="companyId"></param>		/// <returns></returns>		public async Task<GoalResponseModel> GetCompanyGoals()		{			try			{				var url = apiAddress+"/v1/get_all_goals";				var result = await PerformGet<GoalResponseModel>(url, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(error);				});				return result;			}			catch (Exception ex)			{				Debug.WriteLine("GET COMPANY GOALS API CLIENT ERROR: "+ex.Message);				throw;			}		}		/// <summary>		/// Get all organisations that exist in the system		/// </summary>		/// <returns></returns>		public async Task<OrganisationResponseModel> GetAllOrganisations()		{			try			{				var url = apiAddress+"/v1/get_all_organizations";				var result = await PerformGet<OrganisationResponseModel>(url, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(error);				});				return result;			}			catch (Exception ex)			{				Debug.WriteLine("GET ALL ORGANISATIONS API CLIENT ERROR: "+ex.Message);				throw;			}		}		/// Create Log Hours Posts		/// </summary>		/// <param name="requestModel" type="LogHoursRequestModel"></param>		/// <returns></returns>		public async Task<LogHoursResponseModel> PostLogHours(LogHoursRequestModel requestModel)		{			var url = apiAddress+"/v1/save_new_post";			var result = await PerformPost<LogHoursRequestModel, LogHoursResponseModel>(url, requestModel, IRequestFormat.JSON, false, x =>			{				var error = x.Content.ReadAsStringAsync().Result;				throw new PorpoiseException(error);			});			if (result != null)			{				return result;			}			else			{				return null;			}		}		public async Task<LogHoursResponseModel> UpdateLogHours(LogHoursRequestModel requestModel)		{			var url = apiAddress+"/v1/save_post_details";			var result = await PerformPost<LogHoursRequestModel, LogHoursResponseModel>(url, requestModel, IRequestFormat.JSON, false, x =>			{				var error = x.Content.ReadAsStringAsync().Result;				throw new PorpoiseException(error);			});			if (result != null)			{				return result;			}			else			{				return null;			}		}		public async Task<GetPostResponseModel> GetPost(Guid postId)		{			try			{				var url = apiAddress+"/v1/get_post_details?post_uid="+postId+"";				var result = await PerformGet<GetPostResponseModel>(url, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(error);				});				return result;			}			catch (Exception ex)			{				Debug.WriteLine("GET POST DETAILS API CLIENT ERROR: "+ex.Message);				throw;			}		}        public async Task<ResponseModel<Object>> FlagTutorial(Guid employeeUid, string tutorial){

			var url = "" + apiAddress + "/v1/set_tutorial_to_complete/";

            var requestModel = new LoginTutorialRequestModel
			{
                employee_uid = employeeUid,
                tutorial = tutorial

			};
			try
			{
                var result = await PerformPost<LoginTutorialRequestModel, Client.ResponseModel<Object>>(url, requestModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});
				if (result.Successful)
				{
					Debug.WriteLine("Result Success " + result.Successful);
				}
				return result;

			}            catch(Exception ex){                throw;            }        }		/// <summary>		/// Perform the sign in function based on the email and password passed		/// </summary>		/// <param name="email"></param>		/// <param name="password"></param>		/// <returns></returns>		public async Task<LoginResponseModel> PerformSignIn(string email, string password)		{			var loginUrl = ""+apiAddress+"/v1/login/";
            Debug.WriteLine("PERFORMING SIGN IN: "+loginUrl);			var requestModel = new LoginRequestModel			{	Username = email,				Password = password			};			try			{				var result = await PerformPost<LoginRequestModel, LoginResponseModel>(loginUrl, requestModel, IRequestFormat.JSON, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(error);				});

				Debug.WriteLine("MESSAGE: " + result.Message + " Email: "+email+" Password "+password);				if (result != null && result.Successful)				{					AccountInfo.Password = password;					AccountInfo.Email = email;					AccountInfo.Token = result.Token;					return result;				}				return result;			}			catch (PorpoiseException pe)			{				return new LoginResponseModel(false, pe.Message);			}			catch (Exception ex)			{				throw new PorpoiseException(Resource.PorpoiseConnectionError);			}		}

        public async Task<SetNewPasswordResponseModel> SetupNewPassword(string password, string uid)
        {

			try {


				var requestModel = new SetNewPasswordRequestModel
				{
                    Password= password,                    uid = uid

				};                 var newPasswordURL = "" + apiAddress + "/v1/set_new_password/";

                var result = await PerformPost<SetNewPasswordRequestModel, SetNewPasswordResponseModel>(newPasswordURL, requestModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});

				if (result != null && result.Successful)
				{
					AccountInfo.Password = password;
                    //AccountInfo.Email = email;                    Debug.WriteLine("ASSIGNING TOKEN TO HEADER: "+result.Token.ToString());
					AccountInfo.Token = result.Token;

					return result;
				}
				return result;                        }
			catch (PorpoiseException pe)
			{
				return new SetNewPasswordResponseModel(false, pe.Message);
			}
			catch (Exception ex)
			{
				throw new PorpoiseException(Resource.PorpoiseConnectionError);
			}                }		public async Task<PostsActivityResponseModel> GetPosts(bool onlyForUser)		{			string url = "";			if (onlyForUser)			{				url = ""+apiAddress+"/v1/get_user_posts";			}			else			{				url = ""+apiAddress+"/v1/get_all_posts";			}			try			{				var result = await PerformGet<PostsActivityResponseModel>(url, false, x =>				{					var error = x.Content.ReadAsStringAsync().Result;					//AccountInfo.Logout();					throw new PorpoiseException(error);				});				if (result != null && result.Successful)				{					return result;				}                else if (result != null && !result.Successful){                    return null;                }				else				{//AccountInfo.Logout();					return new PostsActivityResponseModel(false);				}			}			catch (Exception ex)			{//AccountInfo.Logout();
             //throw new PorpoiseException(ex.Message);

                return null;			}		}		public async Task<EmployeeResponseModel> getEmployeeRow(Guid userId)		{			try			{				var url = ""+apiAddress+"/v1/get_employee_row?user_uid="+userId+"";				Debug.WriteLine("RETRIEVING EMPLOYEE INFO: "+url);				var result = await PerformGet<EmployeeResponseModel>(url, false, x =>				{					Debug.WriteLine("RETRIEVING EMPLOYEE INFORMATION " + x.ToString());					var error = x.Content.ReadAsStringAsync().Result;					throw new PorpoiseException(error);				});				return result;			}			catch (Exception ex)			{				throw;			}		}		#region Util methods 		private async Task<T> PerformAction<T>(Func<HttpClient, Task<HttpResponseMessage>> action, bool requiresAuthentication = false, Action<HttpResponseMessage> errorHandler = null, bool xml = false)		{			var client = Client(xml);			{				Debug.WriteLine("TRYING TO GET RESPONSE");				HttpResponseMessage response = await action(client).ConfigureAwait(false);				Debug.WriteLine("RESPONSE ");				if (response.IsSuccessStatusCode)				{
                    Debug.WriteLine("RESPONSE IS SUCCESSFUL");					T result;					if (!xml)					{						string content = await response.Content.ReadAsStringAsync();						Debug.WriteLine(content);						result = await response.Content.ReadAsAsync<T>();					}					else					{						XmlSerializer serializer = new XmlSerializer(typeof(T));						try						{							string content = await response.Content.ReadAsStringAsync();							result = (T)serializer.Deserialize(new StringReader(content));						}						catch						{							if (errorHandler != null)							{								errorHandler(response);							}							return default(T);						}					}					return result;				}				else				{
                    Debug.WriteLine("RESPONSE UNSUCCESSFUL");					if (errorHandler != null)					{						errorHandler(response);					}					return default(T);				}			}		}		private async Task<T> PerformGet<T>(string path, bool xml = false, Action<HttpResponseMessage> errorHandler = null)		{			try			{				var temp = await PerformAction<T>(x => x.GetAsync(path), xml: xml, errorHandler: errorHandler);				return temp;			}			catch (Exception ex)			{				Debug.WriteLine(ex.Message);				throw;			}		}		private Task<T> PerformGet<T>(string url, params object[] parameters)		{			return PerformGet<T>(string.Format(url, parameters), errorHandler: HandleError);		}		public async Task<GiveWelldoneResponseModel> GiveWelldone(Guid? postId)		{			var url = ""+apiAddress+"/v1/give_well_done?post_uid="+postId+"";			var result = await PerformGet<GiveWelldoneResponseModel>(url, false, x =>			{								var error = x.Content.ReadAsStringAsync().Result;				throw new PorpoiseException(error);			});			return result;		}		public async Task<RemoveWelldoneResponseModel> RemoveWelldone(Guid? postId)		{			var url = ""+apiAddress+"/v1/remove_well_done?post_uid="+postId+"";			var result = await PerformGet<RemoveWelldoneResponseModel>(url, false, x =>			{				var error = x.Content.ReadAsStringAsync().Result;				throw new PorpoiseException(error);			}			);			return result;		}		public async Task<DeletePostResponseModel> DeletePost(Guid? postId)		{			var url = ""+apiAddress+"/v1/delete_post?post_uid="+postId+"";			var result = await PerformGet<DeletePostResponseModel>(url, false, x =>			{				var error = x.Content.ReadAsStringAsync().Result;				throw new PorpoiseException(error);			});			return result;		}        //ReportInnappropriate Post        public async Task<ResponseModel<Object>> ReportPost(Guid? postId, Guid? flaggedByUserId){

			var url = "" + apiAddress + "/v1/flag_post/";
			
            var requestModel = new ReportPostRequestModel
			{
                post_uid = postId.Value,
                user_uid = flaggedByUserId.Value

			};
			try
			{
                var result = await PerformPost<ReportPostRequestModel, Client.ResponseModel<Object>>(url, requestModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});
                if (result.Successful)
                {
                    Debug.WriteLine("Result Success " + result.Successful);
                }                return result;

			}
			
			catch (Exception ex)
			{
                return null;
			}        }        //Report user        public async Task<ResponseModel<Object>> ReportUser(Guid? postId, Guid? userId, string reason){

			var url = "" + apiAddress + "/v1/flag_user/";

            var requestModel = new ReportUserRequestModel
			{
                post_uid = postId.Value,
                user_uid = userId.Value,                reason = reason

			};
			try
			{
				var result = await PerformPost<ReportUserRequestModel, Client.ResponseModel<Object>>(url, requestModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});
				if (result.Successful)
				{
					Debug.WriteLine("Result Success " + result.Successful);
				}
				return result;

			}            catch(Exception ex){                Debug.WriteLine(ex);                return null;            }        }        public async Task<ResponseModel<Object>> InviteCoWorker(Guid? employeeUid, string name, string email){            try{               var url = "" + apiAddress + "/v1/invite_coworker/";

                var requestModel = new InviteCoworkerRequestModel
                {
                    employee_uid = employeeUid.Value,                    name = name,                    email = email

				};

				var result = await PerformPost<InviteCoworkerRequestModel, Client.ResponseModel<Object>>(url, requestModel, IRequestFormat.JSON, false, x =>
				{
					var error = x.Content.ReadAsStringAsync().Result;
					throw new PorpoiseException(error);
				});
				if (result.Successful)
				{
					Debug.WriteLine("Result Success " + result.Successful);
				}
				return result;            }            catch(Exception ex){                Debug.WriteLine(ex);                return null;            }        }		private async Task<TResult> PerformPost<TRequest, TResult>(string path, TRequest body, IRequestFormat format = IRequestFormat.JSON, bool requiresAuthentication = false, Action<HttpResponseMessage> errorHandler = null)
        {
            Debug.WriteLine("PERFORMING POST "+format.ToString());			switch (format)			{				case IRequestFormat.JSON:
                    Debug.WriteLine("FORMAT IS JSON");
                    Debug.WriteLine("PATH: " + path);
                    Debug.WriteLine("BODY: " + body.ToString());
                    var result = await PerformAction<TResult>(x => x.PostAsJsonAsync(path, body), requiresAuthentication, errorHandler);
                    Debug.WriteLine("RESULT: "+result.ToString());					return result;				case IRequestFormat.XML:					return await PerformAction<TResult>(x => x.PostAsync(path, body, new XmlMediaTypeFormatter() { UseXmlSerializer = true }), requiresAuthentication, errorHandler, true);				case IRequestFormat.STRING:					return await PerformAction<TResult>(async x =>					{						var content = body.ToString();						try						{							return await x.PostAsync(path, new StringContent(content));						}						catch						{							throw;						}					}, requiresAuthentication, errorHandler);			}			var temp = default(TResult);			return temp;		}

       private Tuple<string, string>[] buildTestHeaders() {

            List<Tuple<string, string>> headers = new List<Tuple<string, string>>();

            headers.Add(new Tuple<string, string>("X-Api-Key", API_KEY));
            headers.Add(new Tuple<string, string>("X-Porp-ApiVersion", "1.0"));
#if __ANDROID__
			headers.Add(new Tuple<string, string>("X-Porp-Platform", "ANDROID_PORPOISE_APP"));
#elif __IOS__
            headers.Add(new Tuple<string, string>("X-Porp-Platform", "IOS_PORPOISE_APP"));
#else
            headers.Add(new Tuple<string, string>("X-Porp-Platform", "PORPOISE_APP"));
#endif



            //headers.Add(new Tuple<string, string>("X-Porp-ApiVersion", "1.0"));

           // headers.Add(new Tuple<string, string>("X-Porp-Platform", "PORPOISE_APP"));

            if (AccountInfo.Token.HasValue)
            {
                headers.Add(new Tuple<string, string>("X-Token", AccountInfo.Token.ToString()));

                Debug.WriteLine("TOKEN VALUE: " + AccountInfo.Token.ToString());
            }

            return headers.ToArray();                }		private Tuple<string, string>[] buildDefaultHeaders()		{			List<Tuple<string, string>> headers = new List<Tuple<string, string>>();			headers.Add(new Tuple<string, string>("X-Api-Key", API_KEY));			headers.Add(new Tuple<string, string>("X-Porp-ApiVersion", "1.0"));#if __ANDROID__			headers.Add(new Tuple<string, string>("X-Porp-Platform", "ANDROID_PORPOISE_APP"));#elif __IOS__            headers.Add(new Tuple<string, string>("X-Porp-Platform", "IOS_PORPOISE_APP"));#else			headers.Add(new Tuple<string, string>("X-Porp-Platform", "PORPOISE_APP"));#endif			if (AccountInfo.Token.HasValue)			{				headers.Add(new Tuple<string, string>("X-Token", AccountInfo.Token.ToString()));				Debug.WriteLine("TOKEN VALUE: "+AccountInfo.Token.ToString());			}			return headers.ToArray();		}		static readonly char[] padding = { '=' };		private string ToBase64(string src)		{			byte[] toEncodeAsBytes = Encoding.UTF8.GetBytes(src);			return System.Convert.ToBase64String(toEncodeAsBytes).TrimEnd(padding).Replace('+', '-').Replace('/', '_');		}		private void HandleError(HttpResponseMessage obj)		{			var str = obj.Content.ReadAsStringAsync().Result;			throw new PorpoiseException(errorSerializer.Deserialize(new StringReader(str)) as Error);		}		public void Dispose()		{		}



        #endregion
    }	public enum IRequestFormat	{		JSON, XML, FORMS,		STRING	}}