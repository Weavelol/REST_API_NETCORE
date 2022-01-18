﻿using Microsoft.AspNetCore.Mvc;
using Core.Models.Models;
using Services.Intrefaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.ModelsDTO;

namespace Task12.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class OperationTypesController : ControllerBase {
        IService<OperationType, OperationTypeDTO> _service;

        public OperationTypesController(IService<OperationType, OperationTypeDTO> service) {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperationTypeDTO>>> Get() {
            var operationTypes =  await _service.GetAllItemsAsync();
            return operationTypes.ToList();
        }

        // GET api/operationTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OperationTypeDTO>> Get(int id) {
            var operationType = await _service.GetAsync(id);
            if (operationType == null) {
                return NotFound();
            }

            return new ObjectResult(operationType);
        }

        // POST api/operationTypes
        [HttpPost]
        public async Task<ActionResult<OperationTypeDTO>> Post(OperationTypeDTO operationType) {
            if (operationType == null) {
                return BadRequest();
            }

            await _service.CreateAsync(operationType);
            return Ok(operationType);
        }

        // PUT api/operationTypes/
        [HttpPut]
        public async Task<ActionResult<OperationTypeDTO>> Put(OperationTypeDTO operationType) {
            if (operationType == null) {
                return BadRequest();
            }
            await _service.UpdateAsync(operationType);
            return Ok(operationType);
        }

        // DELETE api/operationTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OperationTypeDTO>> Delete(int id) {
            var operationType = _service.GetAsync(id);
            if (operationType == null) {
                return NotFound();
            }
            await _service.DeleteAsync(id);
            return Ok(operationType);
        }

    }
}
