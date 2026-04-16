import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StructDirective } from './struct-directive';

describe('StructDirective', () => {
  let component: StructDirective;
  let fixture: ComponentFixture<StructDirective>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StructDirective],
    }).compileComponents();

    fixture = TestBed.createComponent(StructDirective);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
