﻿namespace _6_Dependencies
{
    public interface ITarget
    {
        void TakeAttack(int attackPoints);
        int Health { get; }
        int GiveExperience();
        bool IsDead();

    }
}
