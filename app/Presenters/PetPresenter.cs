using Veterinary_Clinic._Repositories;
using Veterinary_Clinic.Models;
using Veterinary_Clinic.Presenters.Common;
using Veterinary_Clinic.Views;

namespace Veterinary_Clinic.Presenters
{
    public class PetPresenter
    {
        private readonly IPetView view;
        private readonly IPetRepository repository;
        private readonly BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = [];
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            this.view.SetPetListBindingSource(petsBindingSource);
            LoadAllPetList();
            this.view.Show();
        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel
            {
                Id = Convert.ToInt32(view.PetId),
                Name = view.PetName,
                Type = view.PetType,
                Colour = view.PetColour
            };
            try
            {
                ModelDataValidation.Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Pet added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel) petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
