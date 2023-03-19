using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class Log : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Text text;

    void Start()
    {
        text.text = "Women in STEM";
    }

    // Update is called once per frame
  
    public void ToTitle()
    {
        SceneManager.LoadScene("Title");

    }
    public void OnClickC()
    {
        text.text = "I was born in Warsaw, Poland 1867. My parents were both school teachers who taught me how to read and learn very early. \r\nMy father taught me to love math and physics and my mother was a headmistress of a girl's school. Later, I became a governess to teach children and also earn money for my family.\r\nI went to Paris to attend Sorbonne University and continued learning physics. I was married in 1894 with my husband Pierre Curie and together we made many discoveries. \r\nWe both discovered radium and polonium together, however at the time we did not know of the consequence of working heavily with radioactive substances. \r\nIn 1903, my husband and I were awarded the Nobel Peace Prize for Physics. After my husband passed away, I worked alone as a professor at my University. \r\nIn 1911, I was awarded a second Nobel Prize in chemistry. I found more ways of studying radioactivity which lead to more development in treating cancer. \r\n“Be less curious about people and more curious about ideas” -Marie Curie\r\n";
    }
    public void OnClickJ()
    {
        text.text = "I was born in 1918 in West Virginia. I always had a passion for math and I performed above my classmates in school. Later, I attended West Virginia State College, which was a black university. \r\nBefore I joined NASA, I worked in a black public school. Later I enrolled in a graduate math program and was given a position in the all-black West Area Computing department at the National Advisory Committee for Aeronautics, which was called NACA at the time.  \r\nAfter we heard in 1957 that the Soviet Union launched a satellite named Sputnik into space, NACA became known as NASA and we worked heavily on learning more about space travel.\r\n In 1962, I helped out, by hand, solving equations that would calculate the trajectory of our space capsule to check over the computers that were not very reliable. \r\nPresident Barack Obama awarded me with the Presidential Medal of Freedom in 2015.\r\n“Girls are capable of doing everything men are capable of doing. Sometimes they have more imagination than men.” -Katherine Johnson\r\n";
    }
    public void OnClickP()
    {
        text.text = "I was born in 1952 in Virgina but spent most of my childhood growing up in New Jersey. \r\nIn 1973 I received my Bachelor of Science degree from the Massachusetts Institute of Technology, and in 1976 I received a degree in mathematics. I later received my PhD in computer science from MIT in 1988.\r\nI worked in BBN, where I helped develop software. One of my greatest contributions is an algorithm called the Spanning Tree Protocol. This algorithm works in networking and allows for data to deliver through in links in a tree system. \r\nI became a professor at Harvard University and the University of Washington. I continued to improve my Spanning Tree Protocol algorithm and I have won multiple awards including Inventor of the Year in 2004. \r\n“The kind of diversity that I think really matters isn’t skin shade and body shape, but different ways of thinking.” -Radia Perlman\r\n";
    }
}
