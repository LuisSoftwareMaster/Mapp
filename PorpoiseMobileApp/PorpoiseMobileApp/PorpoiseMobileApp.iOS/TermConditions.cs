using System;
using Foundation;
using UIKit;

namespace PorpoiseMobileApp.iOS
{
    public partial class TermConditions : UIViewController
    {
        public TermConditions() : base("TermConditions", null)
        {
        }

        NSMutableAttributedString formated;

        private UIViewController _parentViewController;

        public UIViewController ParentViewController{

            get{

                return _parentViewController;

            }
            set{

                _parentViewController = value;

            }

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			this.View.BackgroundColor = PorpoiseColors.Turquoise;
			

			this.contentView.Layer.CornerRadius = 10;

            this.agree.BackgroundColor = PorpoiseColors.Turquoise;
            this.agree.TintColor = UIColor.White;
            this.agree.TouchDown += (sender, e) => {

                RequestAccountViewController vc = (RequestAccountViewController)this._parentViewController;

                vc.ischeck = true;

                vc.Checkbox.SetBackgroundImage(vc.check, UIControlState.Normal);

                this.DismissViewController(false, null);

            };
			this.back.BackgroundColor = PorpoiseColors.lightGrey;
            this.back.TintColor = UIColor.White;

            this.createText();


        } 

        private void appendNormal(string text){

			NSAttributedString normal = new NSAttributedString(text);

            formated.Append(normal);

          

        }

        private void jumpLine(){

            NSAttributedString jump = new NSAttributedString("\n");

            formated.Append(jump);

        }

        private void jumpTwoLines(){

			NSAttributedString jump = new NSAttributedString("\n\n");

			formated.Append(jump);

        }

        private void appendBold(string text){

           UIFont boldFont =  UIFont.FromName("Helvetica-Bold", 17f);

            NSMutableAttributedString bold = new NSMutableAttributedString(text, boldFont);

            formated.Append(bold);

        }

        private void addBullet(){

            this.appendBold("• ");

        }

        private void addTab(){

            this.appendNormal("\t");
        }


        private void createText(){

            this.formated = new NSMutableAttributedString();

            this.appendBold("Porpoise App (Ongozah Inc.) Terms And Conditions");

            this.jumpTwoLines();

            this.appendBold("General");

            this.jumpTwoLines();

            this.appendNormal("This Terms of Use Agreement (the \"Agreement\") sets out legally binding terms and conditions which govern your use of the websites and any mobile applications Inc. (the \"Product(s)\") owned by Ongozah Inc. (the “Company”). By using these Products, you agree to be bound by the Agreement and the Privacy Policy and all other terms and conditions published on the Product by the Company from time to time, each of which is incorporated by reference and each of which may be published without notice to you by Ongozah Inc. (DBA Porpoise) from time to time.\r");

            this.jumpTwoLines();

            this.appendNormal("Your use of the Product(s) is/are governed by whichever version of this Agreement in effect on the date of use. You agree to access information on the Products for the sole purpose of tracking and sharing community involvement and amplifying the culture of your organization, and/or for management purposes within your company to reward and acknowledge the efforts of your employees and share employee involvement. The Company may modify this Agreement at any time without any prior notice to you. Your continued use of, and access to, the Products acts as your acknowledgement of, and agreement to, the then current Terms of Use, and to having reviewed the most current version of the Terms of Use. The terms and conditions appearing in this Agreement are in addition to any other agreements between you and Ongozah Inc., including any customer agreements or account agreements, and any other agreements that govern your use of the products and services, content, tools, and information available through the Product(s). This Agreement does not in any way alter the terms or conditions of any other agreement you may have with the Company, or its subsidiaries, affiliates or licensees. If you do not agree to all the terms of this Agreement and/or the Company’s Privacy Policy, you are not eligible to participate in the Company’s services or otherwise use this Product. This Agreement applies to all users of the Product, including Investors, and customers and all of those who in any way use the Product (“User(s)”).\r");

            this.jumpTwoLines();

            this.appendNormal("The Company reserves the right, in its sole discretion, without any obligation and without any notice requirement, to change, improve or correct the information, materials and descriptions on the Product and to suspend and/or deny Users’ access to the Product(s) for any reason. Any dated information is published as of its date only, and the Company does not undertake any obligation to update or amend any such information. The Company may discontinue or change any services or products described in or offered on the Product(s) at any time. You agree that the Company and its subsidiaries, affiliates and licensees will not be liable to you or to any third party for any such modification, suspension or discontinuance.\r");

            this.jumpTwoLines();

            this.appendBold("Passwords / Registration");

            this.jumpTwoLines();

            this.appendNormal("You must supply the Company with a valid email address and password prior to using the Product. You hereby agree that you shall be the only authorized user of the Product under this Agreement and shall be solely responsible for the confidentiality of any user name, password or other device required to access the Product (\"Passwords\"). You understand that you shall be solely responsible for all Product(s) activity utilizing such Passwords. You agree that use of such Passwords shall act as an electronic signature, and shall be considered the legal equivalent of agreement by your signed written signature.\r");

            this.jumpTwoLines();

            this.appendNormal("Should you become aware of any unauthorized use of your Passwords, you must immediately notify the Company. Upon receipt of such notice, the Company shall take reasonable steps to stop any activity using these Passwords, but neither the Company, nor any of its directors, officers, employees, agents, affiliates or representatives can or will have any responsibility or liability to any person whose claim may arise for any claims with respect to the handling or mishandling of any transaction on the Product resulting from the unauthorized use of these Passwords.\r");

            this.jumpTwoLines();

            this.appendNormal("Users visiting the Product(s) for any purpose certify that at the time of their visit they have attained the age of majority in their jurisdiction, or if Users are below the age of majority in their jurisdiction at the time of their visit, Users certify that they have obtained the express consent of their parent(s) and/ or guardian(s) to do so.\r");

            this.jumpTwoLines();

            this.appendBold("Trademarks and Intellectual Property\r");

            this.jumpTwoLines();

            this.appendNormal("The Company either owns or has the right to license the intellectual property rights, including copyright, in the information found on the Product(s).\r");

            this.jumpTwoLines();

            this.appendNormal("Particular words, phrases, names, designs or logos used on the Product(s) may constitute trademarks, service marks or trade names (collectively, \"Trademarks\") of the Company or other entities. The display of any trade marks on the Product(s) does not imply that a license has been granted for any further use. Any unauthorized downloading, retransmission or other copying or modification of trademarks or other contents of the Product(s) may be a violation of statutory or common law rights which could subject the violator to legal action. No license of any Company intellectual property is granted by use of, or membership to, the Product(s).\r");

            this.jumpTwoLines();

            this.appendBold("No Endorsement\r");

            this.jumpTwoLines();

            this.appendNormal("The Company does not assume responsibility for the accuracy or appropriateness of the information contained in any third party websites or information to which the Product(s) refer(s) or links. In providing links to such sites, the Company in no way acts as a publisher of the material contained on external or third party websites, nor does it control the content of, or maintain any editorial control over such sites. The Company has no tolerance for objectionable content or abusive users on the Product(s) and allows for measures to be taken if an offender is flagged. Such references or links to such third party or external websites is not to be construed to imply that the Company is affiliated or associated with, or is legally authorized to use any trade mark, trade name, logo or copyrighted symbol that may be reflected in the link or the description of the link to such other sites. Reference to any other party or any other products and services on the Product(s) is not an endorsement of that party, its products or its services.\r");

            this.jumpTwoLines();

            this.appendBold("Warranties\r");

            this.jumpTwoLines();

            this.appendNormal("Information and content provided on the Product(s) is believed to be reliable when posted; the Company does not, however, guarantee the quality, accuracy, completeness or timeliness of the information provided. The Company is under no obligation to update the information found on the Product(s). Typographical errors may occur in the information found on the Product(s). The Company may, without notice to the any parties using the Product(s), make changes to the information found on the website.\r");

            this.jumpTwoLines();

            this.appendNormal("Information and content appearing on the Product(s) is created and generated by, and uploaded to the Product(s) by, the Product’s Users. The Company bears no responsibility for such content or the nature thereof. The User hereby agrees to indemnify and hold harmless the Company in respect of any damages or loss whatsoever arising from, or as a result of, information or other content on the Product(s).\r");

            this.jumpTwoLines();

            this.appendNormal("Access to this/these Product(s) is provided on an 'as is' basis. You shall not assume that your use of the Product(s) will be error-free or that the Product will operate without interruption. The User(s) acknowledge(s) that the Product(s) may operate at varying capabilities, speeds and efficiencies depending upon which browser and or devices the User(s) choose(s) to employ when visiting the Product(s). The Company disclaims all warranties, representations and conditions regarding use of the Product(s) or regarding the information provided, including all implied warranties or conditions of merchantability, fitness for particular purposes, non-infringement, whether express or implied, or arising from a course of dealing, usage or trade practice.\r");

            this.jumpTwoLines();

            this.appendBold("Limitation of Liability\r");

            this.jumpTwoLines();

            this.appendNormal("The Company is not responsible for any direct, indirect, special, incidental, consequential or any other damages whatsoever and howsoever caused arising out of, or in connection with, the use of the Product, Users’ reliance upon the information available on the Product(s), or the transmission of confidential information between the Company and the User over the Internet. In any and all events, any liability of the Company is limited in all cases to a maximum of One Hundred Dollars ($100.00) in Canadian currency. You undertake and agree that you will not commence any action against the Company by way of class proceedings or similar type of action.\r");

            this.jumpTwoLines();

            this.appendBold("Choice of Law\r");

            this.jumpTwoLines();

            this.appendNormal("Where appropriate, the laws of Canada and the laws of New Brunswick shall govern as to the interpretation, validity and effect of this Agreement notwithstanding any conflict of laws provisions or your domicile, residence or physical location.");

            this.jumpTwoLines();

            this.appendBold("Severability & Waiver\r");

            this.jumpTwoLines();

            this.appendNormal("If any provision of this Agreement is determined to be invalid, void or unenforceable by reason of any law, rule, administrative order or judicial decision, of competent jurisdiction, such determination shall not affect the validity of the remaining provisions of this Agreement.\n\nExcept as specifically permitted in the Agreement, no provision of this Agreement can be, nor be deemed to be, waived, altered, modified or amended unless agreed to in writing signed by an authorized representative of the Company.\r");

            this.jumpTwoLines();

            this.appendBold("Contact\r");

            this.jumpTwoLines();

            this.appendNormal("All contact information is available on the Site under “Contact Us”.");

            this.jumpTwoLines();


            this.appendBold("Porpoise (Ongozah Inc.) Privacy Policy:");

            this.jumpTwoLines();

            this.appendNormal("Ongozah Inc. (DBA: Porpoise) (the “Company”) treats its customers’ privacy with only the highest regard. The Company strives to ensure such privacy by operating pursuant to ten privacy principles set out in Schedule 1 of the Personal Information Protection and Electronic Documents Act (“PIPEDA”).");

            this.jumpTwoLines();

            this.appendNormal("The Products, and one’s use of them, will be governed by the laws of Canada and the laws of New Brunswick applicable therein. Note, however, that the following Privacy Policy (the “Policy”) is subject to the federal or territorial laws of the location in which the Company’s servers are located and where information is stored.");

            this.jumpTwoLines();

            this.appendNormal("This Policy governs one’s use of the Company’s Products and/or any related applications associated with, or belonging to, the Company.");

            this.jumpTwoLines();

            this.appendNormal("Signing up is voluntary. By accessing and using the Company’s Products or associated applications, creating posts, contributing to posts, or signing up as an individual or organization, one agrees to the terms of this Policy, as well as to the Company’s terms and conditions governing the use of its Products (the “Terms and Conditions”).");

            this.jumpTwoLines();

            this.appendNormal("One’s level of anonymity while using the Company’s website and/ or associated applications will vary depending upon the purpose of such usage. One will be notified in advance where personal details such as names, avatars and e-mail addresses are viewable by other users.");

            this.jumpTwoLines();

            this.appendNormal("To revoke one’s consent to the Company’s collection, use and disclosure of one’s personal information, one may make such a request by contacting the Company through its website or through the address listed below under “Accountability”.");

            this.jumpTwoLines();

            this.appendBold("1. Accountability");

            this.jumpTwoLines();

            this.appendNormal("The Office of the Privacy Commissioner of Canada (the “OPCC”) administers PIPEDA from which the ten privacy principles are taken. Various means of contacting the OPCC to suit one’s purposes can be found at their website at\u00a0https://www.priv.gc.ca/cu-cn/index_e.asp.");

            this.jumpTwoLines();

            this.appendNormal("The Company has appointed Topher Kingsley-Williams as the Privacy Officer accountable for the Company’s compliance with the privacy to which PIPEDA refers.");

            this.jumpTwoLines();

            this.appendBold("If:");

            this.jumpTwoLines();

            this.addBullet();

            this.appendNormal("One wishes to ask directly about the Company’s Privacy Policy;");

            this.jumpLine();

            this.addBullet();

            this.appendNormal("One’s concerns have not been addressed to his or her satisfaction;");

            this.jumpLine();

            this.addBullet();

            this.appendNormal("One would like to be informed of the existence of, use, and disclosure of his or her personal information;");

            this.jumpLine();

            this.addBullet();

            this.appendNormal("One desires access to the information the Company has collected about that person;");

            this.jumpLine();

            this.addBullet();

            this.appendNormal("One wishes to revoke his or her consent to the use of their personal information; or");

            this.jumpLine();

            this.addBullet();

            this.appendNormal("One wishes to lodge a complaint with the Company about the terms of its Privacy Policy or the way in which the Company has handled his or her personal information,");

            this.jumpLine();

            this.appendNormal("Please contact Topher at\u00a0privacy@getporpoise.com.");

            this.jumpTwoLines();

            this.appendNormal("One can reach out to the Company at the following address, and let the Company know if he or she wishes to challenge the Company’s compliance with PIPEDA’s privacy principles:");

            this.jumpTwoLines();

            this.appendNormal("One can reach out to the Company at the following address, and let the Company know if he or she wishes to challenge the Company’s compliance with PIPEDA’s privacy principles:");

            this.jumpTwoLines();

            this.appendBold("2. Identifying Purposes");

            this.jumpTwoLines();

            this.appendNormal("The Company collects and retains information in order to execute the services, potential projects and giving goal. Customer data is kept so that the Company might ably deliver on its services, make modifications and improvements, and develop additional features.");

            this.jumpTwoLines();

            this.appendNormal("By contributing to the Company Products at any time and in any manner to any project or service promoted by the Company and/ or the Company Products, you provide the Company with express permission to share a) all uploaded and submitted content including, but not limited to, pictures, likenesses, event promotional materials, and biographical material and information, and b) your name and contact information, including e-mail address or phone number, for the purposes of measuring, organizing and executing the services, projects and goals promoted by the Company.");

            this.jumpTwoLines();

            this.appendNormal("By contributing to the Company Products at any time and in any manner to any project or service promoted by the Company and/ or the Company Products, organizations and employers certify that they have the consent of their members and/ or employees for the Company to share the names and e-mail addresses of such members and/ or employees for the purposes of the Company and the Company Products. Organizations and employers also provide the Company with express permission to share a) all uploaded and submitted content including, but not limited to, pictures, likenesses, event promotional materials, and biographical material and information, and b) the names and contact information of their members and/ or employees, including their e-mail addresses, for the purposes of organizing and executing the services, projects and goals promoted by the Company.");

            this.jumpTwoLines();

            this.appendBold("3. Consent");

            this.jumpTwoLines();

            this.appendNormal("This Privacy Policy governs one’s use of Ongozah Inc.’s Product and/or related applications. Signing up is voluntary, and by accessing and using the Company’s Products or integrated mobile applications, one agrees to the terms of this Privacy Policy. By accessing and using the Company’s site, one provides the Company with his or her consent to collect use and disclose one’s personal information.");

            this.jumpTwoLines();

            this.appendNormal("This consent can be revoked at any time by contacting the Company through its website or the address listed above.");

            this.jumpTwoLines();

            this.appendBold("4. Limiting Collection");

            this.jumpTwoLines();

            this.appendNormal("Note that Ongozah Inc. collects only information required for, and commensurate with, the products and/ or services users/clients wish to receive.");

            this.jumpTwoLines();

            this.appendNormal("The Company makes no use of persistent identifiers, and its collection of personal information is of limited scope, conducted only to the extent to which the Company requires the information for the efficacy of the Products.");

            this.jumpTwoLines();

            this.appendNormal("Collection of one’s personal information will take place by fair and lawful means, as required by PIPEDA principles. The Company collects log information – among other items, IP addresses, the time and date upon which website visits occur, and the like – sent by users’ browsers to the Company’s servers.");

            this.jumpTwoLines();

            this.appendNormal("The Company will from time to time share some of the user information collected upon the latter’s use of the Product in order to ensure optimal performance of the services for which users sign up.");

            this.jumpTwoLines();

            this.appendNormal("The Company collects, retains and uses information collected from e-mail correspondence between itself and users, but, does so only so that it has the necessary information to effectively deal with user concerns.");

            this.jumpTwoLines();

            this.appendBold("5. Content");

            this.jumpTwoLines();

            this.appendNormal("You own all of the content and information you post on the Product(s), and you can control how it is shared in the Product(s). In addition:");

            this.jumpTwoLines();

            this.addTab();

            this.appendNormal("1. For content that is covered by intellectual property rights, like photos and videos (IP content), you specifically give us the following permission, subject to your\u00a0settings: you grant us a non-exclusive, transferable, sub-licensable, royalty-free, worldwide license to use any IP content that you post on or in connection with the Product(s) (IP License). This IP License ends when you delete your IP content or your account unless your content has been shared with others, and they have not deleted it.");

            this.jumpTwoLines();

            this.addTab();

            this.appendNormal("2. When you delete IP content, it is deleted in a manner similar to emptying the recycle bin on a computer. However, you understand that removed content may persist in backup copies for a reasonable period of time (but will not be available to others).");

            this.jumpTwoLines();

            this.addTab();

            this.appendNormal("3. When you use an application, the application may ask for your permission to access your content and information as well as content and information that others have shared with you.\u00a0 We require applications to respect your privacy, and your agreement with that application will control how the application can use, store, and transfer that content and information.");

            this.jumpTwoLines();

            this.appendBold("6. Limiting Use, Disclosure, and Retention");

            this.jumpTwoLines();

            this.appendNormal("The Company does not use or disclose collected information for purposes other than those for which it was collected, except with the consent of the individual or where such disclosure may be required by law. Note further that the Company retains collected information only as long as necessary in order to meet its purposes as enumerated in this Policy.");

            this.jumpTwoLines();

            this.appendBold("7. Accuracy");

            this.jumpTwoLines();

            this.appendNormal("Ongozah Inc. will ensure that information it collects is as accurate, complete and up-to-date as is necessary for the purposes for which it is used.");

            this.jumpTwoLines();

            this.appendNormal("Note that the Company does not alter or make changes to submitted information.");

            this.jumpTwoLines();

            this.appendNormal("An individual may request a review of their collected information, challenge the accuracy and completeness of this information, and/ or have it amended or deleted where appropriate by making contact with our Privacy Officer at the above e-mail address provided above under “Accountability”. Note that users submitting such requests must adequately identify, both, themselves and the disputed information so that the Company may meet their request, and promptly and effectively address them.");

            this.jumpTwoLines();

            this.appendNormal("In the rare event the Company is unable to comply with such a request for perusal, amendment or deletion of collected information, it will notify the owner of the request of its reasons in writing. The circumstances in which this would occur are limited. For instance, The Company would be unable to fulfill a user’s request where the information disputed involves the personal information of other users or where the information is somehow otherwise required for the Company to meet its obligations under this Policy.");

            this.jumpTwoLines();

            this.appendBold("8. Safeguards");

            this.jumpTwoLines();

            this.appendNormal("The Company collects, uses and discloses users’ personal information in a responsible, fair and lawful manner.");

            this.jumpTwoLines();

            this.appendNormal("The Company uses staple pieces of technology in its ongoing effort to maintain user security and discretion, namely, secure, encrypted, and diligently-monitored servers and communication.");

            this.jumpTwoLines();

            this.appendNormal("If the Company is ever acquired or sold, it will ensure the confidentiality of all collected information prior to any transaction occurring.");

            this.jumpTwoLines();

            this.appendBold("9. Openness");

            this.jumpTwoLines();

            this.appendNormal("Ongozah Inc. shall make readily available, and continue to make readily available to individuals specific information about this Policy, and about its policies and practices governing the management of personal information.");

            this.jumpTwoLines();

            this.appendNormal("Where possible, changes to this Policy will be preceded by notification to users, or by Policy update postings upon the Company’s Products.");

            this.jumpTwoLines();

            this.appendNormal("Note that the Company will not unilaterally change this Policy in a manner that removes or reduces one’s rights under the Policy.");

            this.jumpTwoLines();

            this.appendBold("10. Individual Access");

            this.jumpTwoLines();

            this.appendNormal("The existence, use, and disclosure of individual users’ personal information will be made known to those individual users, and they shall be given access to that information upon request to\u00a0privacy@getporpoise.com.");

            this.jumpTwoLines();

            this.appendBold("11. Challenging Compliance");

            this.jumpTwoLines();

            this.appendNormal("Individuals may, at any time, challenge the Company’s compliance with these ten privacy principles by contacting the Company via one of the channels provided above under “Accountability”.");

            this.jumpTwoLines();

            this.appendNormal("Where individuals remain dissatisfied with the Company’s responses to such inquiries, they will have recourse to the Office of the Privacy Commissioner of Canada which can be communicated with via various means to suit their purposes as set out on their website at\u00a0https://www.priv.gc.ca/cu-cn/index_e.asp.");
            this.jumpTwoLines();
            this.agreementText.AttributedText = formated;
                
        }

        private void buttonsEvents(){

            back.TouchDown += (sender, args) =>
            {

                this.DismissViewController(false, null);

            };

            agree.TouchDown += (sender, e) =>
            {

                if (ParentViewController is RequestAccountViewController)
                {

                    RequestAccountViewController controller = (RequestAccountViewController)ParentViewController;

                    controller.ViewModel.RequestEmployee();

                    this.DismissViewController(false, null);

                }


            };

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			if (ParentViewController is RequestAccountViewController)
			{

				RequestAccountViewController controller = (RequestAccountViewController)ParentViewController;

				porpoiseLogo.Image = Services.PorpoiseImage.getFromURL(controller.ViewModel.TopImage);

				buttonsEvents();

			}
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

