using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using EventRegistrationSystem.Abstract; 
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Infrastructure
{
        public class NinjectDependencyResolver : IDependencyResolver
        {
            private IKernel kernel;
            public NinjectDependencyResolver(IKernel kernelParam)
            {
                kernel = kernelParam;
                AddBindings();
            }
            public object GetService(Type serviceType)
            {
                return kernel.TryGet(serviceType);
            }
            public IEnumerable<object> GetServices(Type serviceType)
            {
                return kernel.GetAll(serviceType);
            }
            private void AddBindings()
            {
            Mock<ICompanyRepository> mock = new Mock<ICompanyRepository>();
            mock.Setup(m => m.Companies).Returns(new List<Company> {
                new Company { Name = "Penatibus Company", Address = "Ap #565-1530 Elit, Street", PhoneNumber = "(896) 317-7876", Email = "dui@nibhPhasellusnulla.org", PrimaryContactName = "Lawrence", PrimaryContactPhoneNumber = "(669) 844-6856", PrimaryContactEmail = "ante.iaculis@est.net", CompanyWebLink = "Shay", CompanyID = 101 },
                new Company { Name = "Etiam Incorporated", Address = "998 Orci Av.", PhoneNumber = "(543) 469-1082", Email = "quam@mauris.com", PrimaryContactName = "Emmanuel", PrimaryContactPhoneNumber = "(412) 272-2283", PrimaryContactEmail = "et.libero.Proin@id.com", CompanyWebLink = "Imelda", CompanyID = 102 },
                new Company { Name = "Fusce Foundation", Address = "4139 Eu Road", PhoneNumber = "(491) 353-2350", Email = "gravida.mauris@aliquetPhasellusfermentum.ca", PrimaryContactName = "Todd", PrimaryContactPhoneNumber = "(814) 425-1167", PrimaryContactEmail = "Aenean@penatibuset.edu", CompanyWebLink = "Bree", CompanyID = 103 },
                new Company { Name = "Metus Aliquam Ltd", Address = "6162 Duis Street", PhoneNumber = "(862) 183-6430", Email = "Aliquam.auctor@pedeCrasvulputate.com", PrimaryContactName = "Perry", PrimaryContactPhoneNumber = "(555) 538-0160", PrimaryContactEmail = "dis.parturient@In.ca", CompanyWebLink = "Winifred", CompanyID = 104 },
                new Company { Name = "Mi Duis Risus Company", Address = "265-4067 Erat, Rd.", PhoneNumber = "(908) 762-9243", Email = "Nulla.aliquet.Proin@etrisusQuisque.net", PrimaryContactName = "Omar", PrimaryContactPhoneNumber = "(106) 379-4517", PrimaryContactEmail = "ante@egestas.edu", CompanyWebLink = "Selma", CompanyID = 105 },
                new Company { Name = "Sit LLC", Address = "607-1688 Curabitur Road", PhoneNumber = "(968) 638-4552", Email = "enim.Nunc.ut@nasceturridiculus.com", PrimaryContactName = "Evan", PrimaryContactPhoneNumber = "(243) 297-8850", PrimaryContactEmail = "in.tempus.eu@egestasnunc.com", CompanyWebLink = "Clare", CompanyID = 106 },
                new Company { Name = "Interdum Curabitur Foundation", Address = "963 Lorem Road", PhoneNumber = "(864) 662-2174", Email = "ante@tristique.ca", PrimaryContactName = "Armand", PrimaryContactPhoneNumber = "(466) 610-3673", PrimaryContactEmail = "molestie.pharetra.nibh@malesuadaid.ca", CompanyWebLink = "Wendy", CompanyID = 107 },
                new Company { Name = "Metus Aliquam Erat Industries", Address = "P.O. Box 852, 9182 Eu St.", PhoneNumber = "(331) 200-7068", Email = "nec.eleifend.non@Phasellusinfelis.edu", PrimaryContactName = "Odysseus", PrimaryContactPhoneNumber = "(606) 681-2684", PrimaryContactEmail = "tincidunt.nunc@nequeInornare.edu", CompanyWebLink = "Nyssa", CompanyID = 108 },
                new Company { Name = "Eget Consulting", Address = "885-2205 Augue Avenue", PhoneNumber = "(542) 582-6743", Email = "Aliquam.nec.enim@arcuVestibulumut.co.uk", PrimaryContactName = "Tyler", PrimaryContactPhoneNumber = "(172) 186-4309", PrimaryContactEmail = "mattis.velit@ante.co.uk", CompanyWebLink = "Rhea", CompanyID = 109 },
                new Company { Name = "Montes Nascetur Limited", Address = "P.O. Box 696, 9484 Dolor Ave", PhoneNumber = "(774) 993-9599", Email = "nulla.ante@lectusconvallisest.co.uk", PrimaryContactName = "Griffin", PrimaryContactPhoneNumber = "(993) 860-1358", PrimaryContactEmail = "quis.turpis@cursusinhendrerit.ca", CompanyWebLink = "Leigh", CompanyID = 110 },
                new Company { Name = "Leo Cras Foundation", Address = "5062 Ultrices Avenue", PhoneNumber = "(415) 619-3445", Email = "sagittis@utpharetrased.net", PrimaryContactName = "Sawyer", PrimaryContactPhoneNumber = "(598) 555-4902", PrimaryContactEmail = "eget.venenatis@sitametorci.net", CompanyWebLink = "Rebecca", CompanyID = 111 },
                new Company { Name = "Phasellus Elit Foundation", Address = "P.O. Box 187, 1363 Aliquet Rd.", PhoneNumber = "(709) 522-7317", Email = "ultrices@eu.com", PrimaryContactName = "Damon", PrimaryContactPhoneNumber = "(213) 468-3643", PrimaryContactEmail = "non.lorem.vitae@loremsit.edu", CompanyWebLink = "Quin", CompanyID = 112 },
                new Company { Name = "Sollicitudin Adipiscing PC", Address = "304 Nec Ave", PhoneNumber = "(515) 567-4856", Email = "ante@aliquetProin.com", PrimaryContactName = "Chancellor", PrimaryContactPhoneNumber = "(938) 363-7123", PrimaryContactEmail = "euismod.ac@luctusvulputate.org", CompanyWebLink = "Kitra", CompanyID = 113 },
                new Company { Name = "Sed Tortor Consulting", Address = "Ap #877-2601 Sapien, St.", PhoneNumber = "(643) 332-0297", Email = "velit.Quisque@Uttincidunt.ca", PrimaryContactName = "Martin", PrimaryContactPhoneNumber = "(621) 680-7497", PrimaryContactEmail = "et@massa.net", CompanyWebLink = "Xyla", CompanyID = 114 },
                new Company { Name = "Nullam Corporation", Address = "632-3260 Ligula Ave", PhoneNumber = "(694) 643-8211", Email = "nulla.vulputate@sapien.ca", PrimaryContactName = "Louis", PrimaryContactPhoneNumber = "(171) 385-3727", PrimaryContactEmail = "mi.lacinia.mattis@ipsum.ca", CompanyWebLink = "Fiona", CompanyID = 115 },
                new Company { Name = "Aliquet LLP", Address = "6790 Nec St.", PhoneNumber = "(696) 283-6377", Email = "nonummy.ut.molestie@commodoipsum.org", PrimaryContactName = "Francis", PrimaryContactPhoneNumber = "(805) 538-1775", PrimaryContactEmail = "massa.Integer.vitae@massaSuspendisseeleifend.ca", CompanyWebLink = "Chiquita", CompanyID = 116 },
                new Company { Name = "Eu Inc.", Address = "P.O. Box 772, 6175 Nunc Ave", PhoneNumber = "(584) 801-7967", Email = "sapien.Nunc.pulvinar@ametmassa.org", PrimaryContactName = "Colorado", PrimaryContactPhoneNumber = "(889) 941-8118", PrimaryContactEmail = "Mauris.molestie@fringilla.net", CompanyWebLink = "Ila", CompanyID = 117 },
                new Company { Name = "Et Libero Foundation", Address = "6985 Gravida Ave", PhoneNumber = "(830) 145-9984", Email = "ultrices@dictumeu.edu", PrimaryContactName = "Cadman", PrimaryContactPhoneNumber = "(163) 983-5972", PrimaryContactEmail = "lorem.ac.risus@ullamcorperDuisat.org", CompanyWebLink = "Jocelyn", CompanyID = 118 },
                new Company { Name = "Vestibulum LLC", Address = "Ap #500-2024 Pede. St.", PhoneNumber = "(515) 903-6394", Email = "Sed.eget@tortor.edu", PrimaryContactName = "Armand", PrimaryContactPhoneNumber = "(104) 134-7928", PrimaryContactEmail = "vestibulum.massa@Inornaresagittis.co.uk", CompanyWebLink = "Naomi", CompanyID = 119 }
        });
            kernel.Bind<ICompanyRepository>().ToConstant(mock.Object);
        }
        }
}
// Used https://www.generatedata.com/ to generate data
// Used https://codebeautify.org/csharpviewer to beutify