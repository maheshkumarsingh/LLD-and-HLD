using Parking_Lot.DTOs;
using Parking_Lot.Models;
using Parking_Lot.Services;

namespace Parking_Lot.Controllers
{
    public class ParkingLotController
    {
        private ParkingLotService _service;

        public ParkingLotController(ParkingLotService service)
        {
            _service = service;
        }
         
        public CreateParkingLotResponseDTO Create(CreateParkingLotRequestDTO request)
        {
            CreateParkingLotResponseDTO createParkingLotResponseDTO = new CreateParkingLotResponseDTO();

            ParkingLot parkingLot;

            try
            {
                parkingLot = _service.Save
                                (
                                  name : request.Name,
                                  address: request.Address,
                                  email: request.Email
                                );
            }
            catch (Exception ex)
            {

                createParkingLotResponseDTO.Status = ResponseStatus.Failure;
                createParkingLotResponseDTO.FailureMessage = ex.Message;
                return createParkingLotResponseDTO;
            }
            createParkingLotResponseDTO.Parkinglot = parkingLot;
            createParkingLotResponseDTO.Status = ResponseStatus.Success;
            return createParkingLotResponseDTO;
        }
    }
}
