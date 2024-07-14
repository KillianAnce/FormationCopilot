function setup() {
  createCanvas(600, 400);
}

function draw() {
  colorMode(HSB);
  background(185, 40, 90); //set background as sky blue
  
  stroke(0); //make outline black
  fill(130, 90, 100); //set color to grass green
  rect(0, 330, 600, 70); //draw a rectangle for the ground
  
  fill(25, 110, 50); //set brick color
  rect(180, 130, 240, 200); //draw the house rectangle
  
  fill(5, 100, 90); //set roof color
  triangle(140, 130, 460, 130, 300, 30); //draw roof triangle
  
  stroke(0); //set stroke colour to black
  //draw horizontal lines for the bricks
  for (let i = 0; i < 9; i++) {
  	line(180, 310 - (i * 20), 419, 310 - (i * 20));
  }
  
  //draw verticle lines for the bircks
  for (let j = 0; j < 10; j++) {
    for (let i = 0; i < 6; i++) {
      line(210 + (cos(PI * j) * 10) + (i * 40), 330 - (20 * j), 210 + (cos(PI * j) * 10) + (i * 40), 310 - (20 * j));
    }
  }
  
  noFill();
  for (let l = 0; l < 9; l++) {
    for (let k = 0; k < (9 - l); k++) {
      arc(175 + (31 * k) + (15.6 * l), 120 - (10 * l), 31, 20, 0, -PI); //draw the lines for the tiles
    }
  }
  
  //draw the door
  fill(30, 130, 20);
  rect(220, 180, 80, 150);
  
  //draw window frame
  rect(325, 190, 75, 75);
  
  //draw the door handle and window glass
  fill(210, 10, 130);
  circle(230, 255, 7);
  rect(330, 195, 65, 65);
  
  //draw window centre
  noStroke(); //turn off outlines
  fill(30, 130, 20);
  rect(358, 190, 10, 75);
  rect(325, 222.5, 75, 10);
}