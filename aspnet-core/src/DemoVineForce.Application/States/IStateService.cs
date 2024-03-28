using DemoVineForce.Authorization.Entities;
using DemoVineForce.States.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVineForce.States
{
    public interface IStateService
    {
        List<State> GetAllStates();

        State GetStateById(int id);
        
        State AddNewState(StateDto state);

        State UpdateState(StateDto state, int id);
        State DeleteState(int id);
    }
}
