using UnityEngine;

namespace BaseClasses
{
    public abstract class Object : MonoBehaviour
    {
        private void Awake()
        {
            Initialize();
        }

        private void Start()
        {
            //Call begin play
            BeginPlay();
        }

        private void Update()
        {
            Tick(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            //Call fixed tick
            FixedTick();
        }

        private void LateUpdate()
        {
            //Call late tick
            LateTick();
        }

        private void OnDestroy()
        {
            //Call destroyed
            Destroyed();
        }
        //Events


        //Initialize the object
        protected virtual void Initialize()
        {
        }

        //Begin play
        protected virtual void BeginPlay()
        {
        }

        //Tick
        protected virtual void Tick(float deltaTime)
        {
        }

        //Destroyed
        protected virtual void Destroyed()
        {
        }

        //Fixed tick
        protected virtual void FixedTick()
        {
        }

        //Late tick
        protected virtual void LateTick()
        {
        }
    }
}