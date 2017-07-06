using System;
namespace PorpoiseMobileApp.ViewModels
{
    public static class InviteCoworkerList
    {
        

        private static  System.Collections.Generic.List<CoworkerModel> coworkersList;

        public static System.Collections.Generic.List<CoworkerModel> CoworkerList{

            get{

                if(coworkersList == null){

                    coworkersList = new System.Collections.Generic.List<CoworkerModel>();


				}

                return coworkersList;

            }

        }

        public static  void addEmployee(Guid employeeUid,string name, string email){

            CoworkerModel obj = new CoworkerModel();

            obj.employeeUid = employeeUid;

            obj.name = name;

            obj.email = email;

            CoworkerList.Add(obj);

        }

        public static void clearList(){

            CoworkerList.Clear();

        }
    }

    public class CoworkerModel
    {

        public Guid employeeUid { get; set; }

        public string name { get; set; }

        public string email { get; set; }

    }
}
