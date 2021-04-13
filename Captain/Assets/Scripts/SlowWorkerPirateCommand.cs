using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Captain.Command;

namespace Captain.Command
{
    public class SlowWorkerPirateCommand : ScriptableObject, IPirateCommand
    {
        private float TotalWorkDuration; // 20- 40 seconds in total - planned
        private float TotalWorkDone;    // how much time worked (compare with 20 - 40) - real
        private float CurrentWork;      // within the 8 seconds cycle, how much time spent (should produce 1 item or not)
        private const float PRODUCTION_TIME = 8.0f; // produce 1 item each 8 seconds
        private bool Exhausted = false;


        public void OnEnable()
        {
            this.TotalWorkDuration = Random.value * 20.0f + 20.0f;
            //Debug.Log(this.TotalWorkDuration);
        }

        public SlowWorkerPirateCommand()
        {
            this.TotalWorkDone = 0.0f;
            this.CurrentWork = 0.0f;
            //this.OnEnable();
        }

        public bool Execute(GameObject pirate, Object productPrefab)
        {
            this.TotalWorkDone += Time.deltaTime;
            this.CurrentWork += Time.deltaTime;
            //Debug.Log(TotalWorkDuration);
            //This function returns false when no work is done. 
            //After you implement work according to the specification and
            //generate instances of productPrefab, this function should return true.
            if (this.TotalWorkDuration <= this.TotalWorkDone)
            {
                return false;
            } 
            else
            {
                if (this.CurrentWork >= PRODUCTION_TIME)
                {
                    var mushroom = (GameObject)Instantiate(productPrefab, pirate.transform.localPosition, pirate.transform.rotation);
                    var mushroomRigidBody = mushroom.GetComponent<Rigidbody2D>();
                    mushroomRigidBody.velocity = mushroom.transform.forward * 50f;
                    mushroomRigidBody.AddForce(new Vector2(Random.value, Random.value) * 260.0f);
                    mushroom.transform.position = new Vector2(pirate.transform.position.x, pirate.transform.position.y);
                    this.CurrentWork = 0.0f;
                    return true;
                }
                else 
                {
                    return true;
                }
            }
            
        }
    }
}