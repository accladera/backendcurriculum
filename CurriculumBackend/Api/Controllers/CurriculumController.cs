using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Domain.Entities;
using Services.Command.CurriculumCommand;
using Services.Query.CurriculumQuery;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/curriculum")]
    [ApiController]

    public class CurriculumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CurriculumController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Trae solo un libro
        /// </summary>
        /// <param name="Id">Id del libro</param>
        /// <returns></returns>
        [Route("{Id}")]
        [HttpGet]
        //[TransactionAuthorize]
        public async Task<ActionResult> GetCurriculum(int Id)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCurriculumQuery
                {
                    Id = Id
                }));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }

        /// <summary>
        /// Trae los curriculum del usuario
        /// </summary>
        /// <param name="IdUser">Id del usuario</param>
        /// <returns></returns>
        [Route("{IdUser}/user")]
        [HttpGet]
        //[TransactionAuthorize]
        public async Task<ActionResult> GetListCurriculumByUser(int IdUser)
        {
            try
            {
                return Ok(await _mediator.Send(new ListCurriculumByUserQuery
                {
                    IdUser = IdUser
                }));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }


        /// <summary>
        /// Elemina un curriculum
        /// </summary>
        /// <param name="IdCurriculum">Id del curriculum</param>
        /// <returns></returns>
        [Route("{IdCurriculum}/delete")]
        [HttpDelete]
        //[TransactionAuthorize]
        public async Task<ActionResult> DeleteCurriculum(int IdCurriculum)
        {
            try
            {
                return Ok(await _mediator.Send(new DeleteCurriculumCommand
                {
                    CurriculumId = IdCurriculum
                }));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {

                return StatusCode(500);
            }
        }


        /// <summary>
        /// Crea un curriculum
        /// </summary>
        /// <returns>El id del curriculum</returns>
        [HttpPost]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<int>> CrearCurriculum(StoreCurriculumCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Update del curriculum
        /// </summary>
        ///  <param name="IdCurriculum">Id del curriculum</param>
        /// <returns>ok</returns>
        [HttpPut("curriculum/{IdCurriculum}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculum(StoreCurriculumCommand model, int IdCurriculum)
        {
            try
            {
                model.SetId(IdCurriculum);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Habilidades del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("abilities")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumAbilities(StoreCurriculumAbilitiesCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Habilidades del curriculum
        /// </summary>
        ///  <param name="IdAbilities">Id del habilities</param>
        /// <returns>ok</returns>
        [HttpPut("abilities/{IdAbilities}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumAbilities(StoreCurriculumAbilitiesCommand model, int IdAbilities)
        {
            try
            {
                model.SetId(IdAbilities);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion adicional del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("information")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumInformations(StoreCurriculumAditionalInformationCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion adicional del curriculum
        /// </summary>
        ///  <param name="IdInformation">Id del informacion</param>
        /// <returns>ok</returns>
        [HttpPut("information/{IdInformation}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumInformation(StoreCurriculumAditionalInformationCommand model, int IdInformation)
        {
            try
            {
                model.SetId(IdInformation);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Experencia adicional del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("experence")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumExperence(StoreCurriculumExperienceCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion experiencia del curriculum
        /// </summary>
        ///  <param name="IdExperence">Id del experencia</param>
        /// <returns>ok</returns>
        [HttpPut("experence/{IdExperence}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumExperence(StoreCurriculumExperienceCommand model, int IdExperence)
        {
            try
            {
                model.SetId(IdExperence);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion general del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("general")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumGeneral(StoreCurriculumGeneralCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion General del curriculum
        /// </summary>
        ///  <param name="IdGeneral">Id del general</param>
        /// <returns>ok</returns>
        [HttpPut("general/{IdGeneral}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumGeneral(StoreCurriculumGeneralCommand model, int IdGeneral)
        {
            try
            {
                model.SetId(IdGeneral);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Idioma del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("idom")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumIdom(StoreCurriculumIdiomCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion Idioma del curriculum
        /// </summary>
        ///  <param name="IdIdom">Id del idoma</param>
        /// <returns>ok</returns>
        [HttpPut("idom/{IdIdom}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumIdom(StoreCurriculumIdiomCommand model, int IdIdom)
        {
            try
            {
                model.SetId(IdIdom);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// Referencia del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("reference")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumReference(StoreCurriculumReferenceCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion Referencia del curriculum
        /// </summary>
        ///  <param name="IdReference">Id del referencia</param>
        /// <returns>ok</returns>
        [HttpPut("reference/{IdReference}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumReference(StoreCurriculumReferenceCommand model, int IdReference)
        {
            try
            {
                model.SetId(IdReference);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Estudios del curriculum
        /// </summary>
        /// <returns>ok</returns>
        [HttpPost("studies")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> StoreCurriculumStudies(StoreCurriculumStudiesCommand model)
        {
            try
            {
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Informacion estudios del curriculum
        /// </summary>
        ///  <param name="IdStudies">Id del estudio</param>
        /// <returns>ok</returns>
        [HttpPut("studies/{IdStudies}")]
        // [TransactionAuthorize]
        [AllowAnonymous]
        public async Task<ActionResult<bool>> UpdateCurriculumStudies(StoreCurriculumStudiesCommand model, int IdStudies)
        {
            try
            {
                model.SetId(IdStudies);
                return Ok(await _mediator.Send(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }




}