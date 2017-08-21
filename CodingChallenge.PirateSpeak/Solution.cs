﻿using System;
using System.Linq;
using System.Collections.ObjectModel

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            // throw new NotImplementedException();
        }
    }
};


// split letters into indexes of array
// put all in lowercase
// will need to get array length
// foreach
// search dictionary for all letters starting with first
// then followed with all for second, all for third, etc
// if match, run with next indexes

// or

// array of all scrambled combinations
// then match indexes to dictionary
// add matches to new array




function setUp (jumble, dictionary){
    let letters = jumble.ToLower().split('');  //set up array of letters from user entry

    function firstUnscramble (letters){
        let mixletters = [];     // temp storage for each scramble, to be cleared each time
        let firstMix = [];   // firstRun results
        let finalMix = [];  //  all final possible scrambles
        let k = Math.pow(letters.length, 2) + 1;
        function mainRun (letters){
            let n = letters.length; // determine length of array
            if (n!=0){
                function firstRun (letters){               // rotate order of letters and push to array
                    for (let i = 0; i < letters.length; i++)
                    {
                        mixletters.push(i);    // create scramble
                    }
                    let mixWord = mixletters.join(',');  //join letters together into one scramble
                    firstMix.push(mixWord);  // add scramble to results array
                    finalMix.push(mixWord); //add scramble to final results
                    mixletters = [];   // clear temp storage
                    n = n-1;   //reduce counter
                    k= k-1
                    let popped = letters.pop();  //remove last index
                    let reworked = letters.splice(0,0,popped);    //add last index to first spot
                    firstRun(reworked);
                }
            };
            else {
                break;
        }

        function secondRun (newLetters){
            let n = newLetters.length;
            if (n!=0){
                for (int i = 0; i < n; i++)
                {
                    let spliced = newLetters.splice((n-(i+1)),1);
                    let reworked = newLetters.splice(0,0,spliced);
                    mainRun(reworked);
                }
            }
        };
        };
        secondUnscramble(firstMix);
    }

    function secondUnscramble (words){   // function to take firstMix and create more scrambled options
        foreach (var word in words)
        {
            let splitWord = word.split('');
            let spliced = splitWord.splice(1,1);  //swap around first two indexes
            let reworked = splitWord.splice(0,0,spliced);
            let n = splitWord.length;
            function mainRun (letters, n){
                while (n!=0){                   // run reworked word through same firstUnscramble process
                    for (let i = 0; i < letters.length; i++)
                    {
                        mixletters.push(i);    // create scramble
                    }
                    let mixWord = mixletters.join(',');  //join letters together into one scramble
                    firstMix.push(mixWord);  // add scramble to results array
                    finalMix.push(mixWord); //add scramble to final results
                    mixletters = [];   // clear temp storage
                    n = n-1;   //reduce counter
                    let popped = letters.pop();  //remove last index
                    let reworked = letters.splice(0,0,popped);    //add last index to first spot
                    mainRun(reworked, n);
                };
            };
        };
        compareWords(finalMix, dictionary);
    }

    function compareWords(scrambled, dictionary){

    }

}