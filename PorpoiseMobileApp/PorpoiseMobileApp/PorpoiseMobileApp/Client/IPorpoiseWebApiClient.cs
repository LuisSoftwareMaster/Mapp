using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PorpoiseMobileApp.Models;

namespace PorpoiseMobileApp.Client
{
	public interface IPorpoiseWebApiClient
	{
		void Dispose();

		Task<EmployeeResponseModel> GetEmployee();
		Task<GoalResponseModel> GetCompanyGoals();
		Task<OrganisationResponseModel> GetAllOrganisations();
		Task<PostsActivityResponseModel> GetPosts(bool onlyForUser);

		Task<GetPostResponseModel> GetPost(Guid postId);
		Task<LoginResponseModel> PerformSignIn(string email, string password);
		Task<LogHoursResponseModel> PostLogHours(LogHoursRequestModel requestModel);
		Task<LogHoursResponseModel> UpdateLogHours(LogHoursRequestModel requestModel);
		//Task<DeleteLogHoursResponseModel> DeleteLogHours(DeleteLogHoursRequestModel requestModel);
		Task<DeletePostResponseModel> DeletePost(Guid? postId);
		Task<GiveWelldoneResponseModel> GiveWelldone(Guid? postId);

		Task<RemoveWelldoneResponseModel> RemoveWelldone(Guid? postId);

		Task<EmployeeResponseModel> getEmployeeRow(Guid userId);

		Task<string> GetCompanyName();

		Task<RequestEmployeeResponseModel> PerformRequestEmployee(string Fullname, string CompanyName, string companyEmail);

        Task<ResponseModel<Object>> ReportPost(Guid? postId, Guid? flaggedByUserId);

        Task<ResponseModel<Object>> ReportUser(Guid? postId, Guid? userId, string reason);

        Task<SignupResponseModel> Signup(string email, string company_name, string first_name, string last_name);

        Task<ResponseModel<Object>> Confirmcode(string mobilecode);

        Task<SetNewPasswordResponseModel> SetupNewPassword(string password, string uid);

        Task<ResponseModel<Object>> InviteCoWorker(Guid? employeeUid, string name, string email);

        Task<ResponseModel<Object>> FlagTutorial(Guid employeeUid, string tutorial);

		//Task<Gift> GetGift(Guid giftId);
		//Task<Goal> GetGoal(Guid goalId);
		//Task<User> GetUser(string email, string password);
	}
}
