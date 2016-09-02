﻿using UnityEngine;
        regenerateVector();
    {
        moveVector = new Vector2(Random.Range(minimumXVector, maximumXVector), Random.Range(minimumYVector, maximumYVector));
        if(changeAtIntervalls)
        {
            StartCoroutine(waitTime());
        }
    }
    {
        yield return new WaitForSeconds(timeInterval);
        regenerateVector();
    }