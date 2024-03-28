using DemoVineForce.Authorization.Entities;
using DemoVineForce.EntityFrameworkCore;
using DemoVineForce.States.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVineForce.States
{
    public class StateService : IStateService
    {
        protected DemoVineForceDbContext _db;
        public StateService(DemoVineForceDbContext db)
        {
            _db = db;   
        }
        public State AddNewState(StateDto state)
        {
            State newState = new State();

            newState.StateName = state.StateName;

            _db.States.Add(newState);
            _db.SaveChanges();

            return newState;
        }

        public State DeleteState(int id)
        {
            var state = _db.States.Find(id);
            if (state == null)
            {
                return null;
            }
            _db.States.Remove(state);
            _db.SaveChanges();

            return state;
        }

        public List<State> GetAllStates()
        {
            var stateList = _db.States.ToList();

            return stateList;
        }

        public State GetStateById(int id)
        {
            var state = _db.States.Find(id);

            return state;
        }

        public State UpdateState(StateDto state, int id)
        {
            var updateState = new State();
            {
                updateState.StateName = state.StateName;
            }

            _db.Entry(updateState).State = EntityState.Modified;

            _db.SaveChanges();
            return _db.States.Find(id);
        }
    }
}
